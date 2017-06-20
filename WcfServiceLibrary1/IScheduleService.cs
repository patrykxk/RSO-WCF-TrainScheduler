using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace TrainScheduleService
{
    [ServiceContract]
    public interface IScheduleService
    {
        [OperationContract]
        string GetData();
        [OperationContract]
        List<List<string>> GetTrainsFromTo(string startingCity, string endCity,
            DateTime startTime, DateTime endTime);
    }
}
