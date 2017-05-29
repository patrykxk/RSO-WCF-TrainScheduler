using System;

namespace WcfServiceLibrary1
{
    class Schedule
    {
        String startingCity;
        String endCity;
        DateTime departureTime;
        DateTime arrivalTime;

        public Schedule(string startingCity, string endCity, DateTime departureTime, DateTime arrivalTime)
        {
            this.StartingCity = startingCity;
            this.EndCity = endCity;
            this.DepartureTime = departureTime;
            this.ArrivalTime = arrivalTime;
        }

        public string StartingCity { get => startingCity; set => startingCity = value; }
        public string EndCity { get => endCity; set => endCity = value; }
        public DateTime DepartureTime { get => departureTime; set => departureTime = value; }
        public DateTime ArrivalTime { get => arrivalTime; set => arrivalTime = value; }
    }
}
