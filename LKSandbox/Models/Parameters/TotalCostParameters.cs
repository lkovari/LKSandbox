using LKSandbox.Interfaces.Parameters;

namespace LKSandbox.Models.Parameters
{
    public class TotalCostParameters : ITotalCostParameters
    {
        public IDateRange DateRange { get; }

        public decimal DailyCosts { get; }

        public string Name { get; }

        public TotalCostParameters(IDateRange dateRange, decimal dailyCosts, string name)
        {
            DateRange = dateRange;
            DailyCosts = dailyCosts;
            Name = name;
        }
    }
}
