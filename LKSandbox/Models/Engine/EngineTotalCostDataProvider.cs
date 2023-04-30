using LKSandbox.Interfaces;
using LKSandbox.Interfaces.Engine;

namespace LKSandbox.Models.Engine
{
    public class EngineTotalCostDataProvider : IEngineTotalCostDataProvider
    {
        public DateOnly Installation { get; }

        public EngineTotalCostDataProvider(DateOnly date)
        {
            Installation = date;
        }

        public ITotalCostData ProvideData()
        {
            return new TotalCostData(19651966);
        }
    }
}
