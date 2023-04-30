using LKSandbox.Interfaces;

namespace LKSandbox.Models
{
    internal class TotalCostData : ITotalCostData
    {
        public decimal TotalCost { get; }
        public TotalCostData(decimal totalCost)
        {
            this.TotalCost = totalCost;
        }
    }
}
