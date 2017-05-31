using System;
using WcfServiceLibrary1;

namespace TrainScheduleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var proxy = new ScheduleService();

            proxy.GetData();
            //var list = proxy.GetTrainsByStartingCity("A");
            var list = proxy.GetTrainsFromTo("A", "B", new DateTime(2017,05,10,8,0,0), new DateTime(2017, 05, 11, 8, 0,0));
            
            foreach(var s in list)
            {
                Console.WriteLine(s);
            }



            Console.ReadKey();
        }
    }
}
