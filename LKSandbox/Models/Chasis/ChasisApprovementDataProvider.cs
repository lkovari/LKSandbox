using LKSandbox.Interfaces;
using LKSandbox.Interfaces.Chasis;

namespace LKSandbox.Models.Chasis
{
    internal class ChasisApprovementDataProvider : IChasisApprovementDataProvider
    {
        public DateOnly Approvement { get; }

        public ChasisApprovementDataProvider(DateOnly date)
        {
            Approvement = date;
        }

        public IApprovementData ProvideData()
        {
            return new ApprovementData(new DateOnly(), false);
        }
    }
}
