using LKSandbox.Interfaces.Parameters;
using LKSandbox.Interfaces.Result;

namespace LKSandbox.Interfaces.DataProducers
{
    public interface IApprovementDataProducer
    {
        public IApprovementParameters ApprovementParameters { get; }
        public IApprovementData ProduceData<T>(T approvementParameters) where T : IApprovementParameters;
    }
}
