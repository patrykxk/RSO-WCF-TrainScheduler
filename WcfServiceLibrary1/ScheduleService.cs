using System;
using System.Collections.Generic;
using System.IO;
using WcfServiceLibrary1;

namespace TrainScheduleService
{
    public class ScheduleService : IScheduleService
    {
        List<Schedule> trains = new List<Schedule>();

        public string GetData()
        {
            using (var fs = File.OpenRead(@"E:\Pobrane\trains.csv"))
            using (var reader = new StreamReader(fs))
            {
                if (!reader.EndOfStream)
                {
                    reader.ReadLine();
                }
                while (!reader.EndOfStream)
                {

                    var line = reader.ReadLine();
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

            foreach(Schedule train in trains){
                if (train.StartingCity.Equals(startingCity))
                {
                    String trainString = train.StartingCity + ","+ train.DepartureTime + "," + train.EndCity + "," + train.ArrivalTime;
                    foundTrains.Add(trainString);
                }
            }

            return foundTrains;
        }



    }

 
}
