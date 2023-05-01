using LKSandbox.Interfaces.Parameters;
using LKSandbox.Interfaces.Result;

namespace LKSandbox.Interfaces.DataProducers
{
    public interface ITotalCostDataProducer
    {
        public ITotalCostParameters TotalCostParameters { get; }
        public IResultData ProduceData<T>(T totalCostParameters) where T : ITotalCostParameters;
    }
}
