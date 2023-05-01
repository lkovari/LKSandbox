using LKSandbox.Interfaces.Chasis;
using LKSandbox.Interfaces.Parameters;
using LKSandbox.Interfaces.Result;
using LKSandbox.Models.Result;

namespace LKSandbox.Models.Chasis
{
    public class ChasisApprovementDataProducer : IChasisApprovementDataProducer
    {
        public DateOnly Approvement { get; }

        public IApprovementParameters ApprovementParameters { get; }

        public ChasisApprovementDataProducer(DateOnly date, IApprovementParameters approvementParameters)
        {
            Approvement = date;
            ApprovementParameters = approvementParameters;
        }

        public IApprovementData ProduceData<T>(T approvementParameters) where T : IApprovementParameters
        {
            // apply the ApprovementParameters data as parameter to calculate Approved or not or other
            return new ApprovementData(approvementParameters.Name, approvementParameters.DateRange.End, false);
        }
    }
}
