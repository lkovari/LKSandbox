using LKSandbox.Interfaces;
using LKSandbox.Interfaces.Engine;

namespace LKSandbox.Models.Engine
{
    public class EngineApprovementDataProvider : IEngineApprovementDataProvider
    {
        public DateOnly Approvement { get; }

        public EngineApprovementDataProvider(DateOnly date)
        {
            Approvement = date;
        }

        public IApprovementData ProvideData()
        {
            return new ApprovementData(new DateOnly(), true);
        }
    }
}
