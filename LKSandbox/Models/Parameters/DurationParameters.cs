using LKSandbox.Interfaces.Parameters;

namespace LKSandbox.Models.Parameters
{
    public class DurationParameters : IDurationParameters
    {
        public IDateRange DateRange { get; }

        public string Name { get; }

        public DurationParameters(IDateRange dateRange, string name)
        {
            DateRange = dateRange;
            Name = name;
        }
    }
}
