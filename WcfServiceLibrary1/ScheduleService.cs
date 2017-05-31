using System;
using System.Collections.Generic;
using System.IO;
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

        public List<string> GetTrainsByStartingCity(string startingCity)
        {
            List<String> foundTrains = new List<string>();

            foreach (Schedule train in trains)
            {
                if (train.StartingCity.Equals(startingCity))
                {
                    String trainString = train.StartingCity + "," + train.DepartureTime + "," + train.EndCity + "," +
                                         train.ArrivalTime;
                    foundTrains.Add(trainString);
                }
            }

            return foundTrains;
        }

        public List<string> GetTrainsFromTo(string startingCity, string endCity)
        {
            List<String> foundTrains = new List<string>();

            foreach (Schedule train in trains)
            {
                if (train.StartingCity.Equals(startingCity) && train.EndCity.Equals(endCity))
                {
                    String trainString = train.StartingCity + "," + train.DepartureTime + "," + train.EndCity + "," +
                                         train.ArrivalTime;
                    foundTrains.Add(trainString);
                }
            }

            return foundTrains;
        }


        public List<string> GetTrainsFromTo(string startingCity, string endCity, DateTime startTimeInterval,
            DateTime endTimeInterval)
        {
            var foundTrains = new List<string>();
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
                foundTrains.Add("Starting city: " + startingCity + " not found");
            }
            if (!isEndCityFound)
            {
                foundTrains.Add("End city: " + endCity + " not found");
            }
            if (!isEndCityFound || !isStartingCityFound) return foundTrains;

            foreach (Schedule train in trains)
            {
                if (train.StartingCity.Equals(startingCity) && train.EndCity.Equals(endCity) &&
                    train.DepartureTime >= startTimeInterval && train.DepartureTime <= endTimeInterval)
                {
                    string trainString = train.StartingCity + "," + train.DepartureTime + "," + train.EndCity +
                                         "," + train.ArrivalTime;
                    foundTrains.Add(trainString);
                }
            }
            return foundTrains;
        }
    }
}