using LKSandbox.Interfaces;
using LKSandbox.Interfaces.Chasis;

namespace LKSandbox.Models.Chasis
{
    internal class ChasisTotalCostDataProvider : IChasisTotalCostDataProvider
    {
        public DateOnly Installation { get; }

        public ChasisTotalCostDataProvider(DateOnly date)
        {
            Installation = date;
        }

        public ITotalCostData ProvideData()
        {
            return new TotalCostData(19661965);
        }
    }
}
