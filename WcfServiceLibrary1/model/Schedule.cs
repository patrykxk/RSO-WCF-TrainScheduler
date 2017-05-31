using System;

namespace WcfServiceLibrary1.model
{
    public class Schedule
    {
        public string StartingCity { get; set; }
        public string EndCity { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }


        public Schedule(string startingCity, string endCity, DateTime departureTime, DateTime arrivalTime)
        {
            this.StartingCity = startingCity;
            this.EndCity = endCity;
            this.DepartureTime = departureTime;
            this.ArrivalTime = arrivalTime;
        }
    }
}
