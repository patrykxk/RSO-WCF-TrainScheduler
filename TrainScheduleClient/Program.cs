using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainScheduleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            TrainScheduleService.ScheduleService proxy = new TrainScheduleService.ScheduleService();

            
            proxy.GetData();
            var list = proxy.GetTrainsByStartingCity("A");
            foreach(string s in list)
            {
                Console.WriteLine(s);
            }
            Console.ReadKey();
        }
    }
}
