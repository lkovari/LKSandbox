using LKSandbox.Interfaces.Engine;
using LKSandbox.Interfaces.Parameters;
using LKSandbox.Interfaces.Result;
using LKSandbox.Models.Result;

namespace LKSandbox.Models.Engine
{
    public class EngineApprovementDataProducer : IEngineApprovementDataProducer
    {
        public DateOnly Approvement { get; }

        private IApprovementParameters _approvementParameters;
        public IApprovementParameters ApprovementParameters { get => _approvementParameters; }

        public EngineApprovementDataProducer(DateOnly date, IApprovementParameters approvementParameters)
        {
            Approvement = date;
            _approvementParameters = approvementParameters;
        }

        public IResultData ProduceData<T>(T approvementParameters) where T : IApprovementParameters
        {
            // apply the ApprovementParameters data as parameter to calculate Approved or not or other
            return new ApprovementData(_approvementParameters.Name, _approvementParameters.DateRange.End, true);
        }
    }
}
