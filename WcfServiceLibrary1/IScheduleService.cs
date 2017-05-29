using System.Collections.Generic;
using System.ServiceModel;
using WcfServiceLibrary1;

namespace TrainScheduleService
{
    [ServiceContract]
    public interface IScheduleService
    {
        [OperationContract]
        string GetData();
        List<string> GetTrainsByStartingCity(string startingCity);


    }
}
