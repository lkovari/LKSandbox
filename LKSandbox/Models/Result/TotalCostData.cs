using LKSandbox.Interfaces.Result;

namespace LKSandbox.Models.Result
{
    internal class TotalCostData : ITotalCostData
    {
        public decimal TotalCost { get; }

        public string Name { get; }

        public TotalCostData(string name, decimal totalCost)
        {
            Name = name;
            TotalCost = totalCost;
        }
    }
}
