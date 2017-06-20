using System;
using System.Collections.Generic;
using System.IO;
using System.ServiceModel;
using TrainScheduleService;
using WcfServiceLibrary1.model;

namespace WcfServiceLibrary1
{
    public class ScheduleService : IScheduleService
    {
        List<Schedule> trains = new List<Schedule>();

        public string GetData()
        {
            using (var fs = File.OpenRead("../../../trains.csv"))
            using (var reader = new StreamReader(fs))
            {
                if (!reader.EndOfStream)
                {
                    reader.ReadLine();
                }
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    if (line == null) continue;
                    var values = line.Split(',');

                    DateTime departureTime = DateTime.Parse(values[1]);
                    DateTime arrivalTime = DateTime.Parse(values[3]);

                    Schedule schedule = new Schedule(values[0], values[2], departureTime, arrivalTime);

                    trains.Add(schedule);
                }
            }

            return string.Format("Readed: " + trains.Count);
        }


        [FaultContract(typeof(FaultException))]
        public List<List<string>> GetTrainsFromTo(string startingCity, string endCity,
            DateTime startTime, DateTime endTime)
        {
            var indirectTrains = new List<string>();
            var foundTrains = new List<List<string>>();
            var directTrains = new List<string>();

            CheckIfStartingCityAndEndCityExist(startingCity, endCity);

            directTrains.AddRange(FindDirectTrains(startingCity, endCity, startTime, endTime));
            indirectTrains.AddRange(FindIndirectTrains(startingCity, endCity, startTime, endTime));
            
            foundTrains.Add(directTrains);
            foundTrains.Add(indirectTrains);
            return foundTrains;
        }

        private void CheckIfStartingCityAndEndCityExist(string startingCity, string endCity)
        {
            bool isStartingCityFound = false;
            bool isEndCityFound = false;

            foreach (Schedule train in trains)
            {
                if (train.StartingCity.Equals(startingCity))
                {
                    isStartingCityFound = true;
                }
                if (train.EndCity.Equals(endCity))
                {
                    isEndCityFound = true;
                }
            }

            if (!isStartingCityFound)
            {
                throw new FaultException("Starting city: " + startingCity + " not found");
            }
            if (!isEndCityFound)
            {
                throw new FaultException("End city: " + endCity + " not found");
            }
        }

        private List<string> FindDirectTrains(string startingCity, string endCity, DateTime startTime, DateTime endTime)
        {
            var directTrains = new List<string>();
            foreach (Schedule train in trains)
            {
                if (train.StartingCity.Equals(startingCity) && train.EndCity.Equals(endCity) &&
                    train.DepartureTime >= startTime && train.ArrivalTime <= endTime)
                {
                    string trainString = train.StartingCity + "," + train.DepartureTime + "," + train.EndCity +
                                         "," + train.ArrivalTime;
                    directTrains.Add(trainString);
                }
            }
            return directTrains;
        }

        private List<string> FindIndirectTrains(string startingCity, string endCity, DateTime startTime, DateTime endTime)
        {
            var indirectTrains = new List<string>();
            var tempList = new List<string>();
            Schedule prevCity = new Schedule();
            foreach (Schedule train in trains)
            {
                if (train.StartingCity.Equals(startingCity) && train.DepartureTime >= startTime)
                {
                    tempList.Add(train.StartingCity + "," + train.DepartureTime + "," + train.EndCity +
                                 "," + train.ArrivalTime);
                    prevCity = train;
                    foreach (Schedule innerTrain in trains)
                    {
                        if (innerTrain.StartingCity.Equals(prevCity.EndCity) && innerTrain.ArrivalTime <= endTime &&
                            innerTrain.DepartureTime > prevCity.ArrivalTime)
                        {
                            tempList.Add(innerTrain.StartingCity + "," + innerTrain.DepartureTime + "," + innerTrain.EndCity +
                                         "," + innerTrain.ArrivalTime);
                            if (innerTrain.EndCity.Equals(endCity))
                            {
                                indirectTrains.AddRange(tempList);
                                indirectTrains.Add(System.Environment.NewLine);
                                break;
                            }
                            prevCity = innerTrain;
                        }
                        
                    }
                }
                tempList = new List<string>();
            }

            return indirectTrains;
        }
    }
}