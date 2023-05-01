using LKSandbox.Interfaces.Chasis;
using LKSandbox.Interfaces.Parameters;
using LKSandbox.Interfaces.Result;
using LKSandbox.Models.Result;

namespace LKSandbox.Models.Chasis
{
    public class ChasisTotalCostDataProducer : IChasisTotalCostDataProducer
    {
        public DateOnly Installation { get; }

        public ITotalCostParameters TotalCostParameters { get; }

        public ChasisTotalCostDataProducer(DateOnly date, ITotalCostParameters totalCostParameters)
        {
            Installation = date;
            TotalCostParameters = totalCostParameters;
        }

        public IResultData ProduceData<T>(T totalCostParameters) where T : ITotalCostParameters
        {
            var days = totalCostParameters.DateRange.End.DayNumber - totalCostParameters.DateRange.Begin.DayNumber;
            // apply the TotalCostParameters data as parameter to calculate the Total Cost
            return new TotalCostData(totalCostParameters.Name, totalCostParameters.DailyCosts * days);
        }
    }
}
