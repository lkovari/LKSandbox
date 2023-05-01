using LKSandbox.Interfaces.Engine;
using LKSandbox.Interfaces.Parameters;
using LKSandbox.Interfaces.Result;
using LKSandbox.Models.Result;

namespace LKSandbox.Models.Engine
{
    public class EngineTotalCostDataProducer : IEngineTotalCostDataProducer
    {
        public DateOnly Installation { get; }

        private ITotalCostParameters _totalCostParameters;
        public ITotalCostParameters TotalCostParameters { get => _totalCostParameters; }

        public EngineTotalCostDataProducer(DateOnly date, ITotalCostParameters totalCostParameters)
        {
            Installation = date;
            _totalCostParameters = totalCostParameters;
        }

        public IResultData ProduceData<T>(T totalCostParameters) where T : ITotalCostParameters
        {
            var days = totalCostParameters.DateRange.End.DayNumber - totalCostParameters.DateRange.Begin.DayNumber;
            // apply the TotalCostParameters data as parameter to calculate the Total Cost
            return new TotalCostData(totalCostParameters.Name, totalCostParameters.DailyCosts * days);
        }
    }
}
