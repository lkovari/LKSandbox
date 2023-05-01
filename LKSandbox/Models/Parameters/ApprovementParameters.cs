using LKSandbox.Interfaces.Parameters;

namespace LKSandbox.Models.Parameters
{
    public class ApprovementParameters : IApprovementParameters
    {
        public IDateRange DateRange { get; }

        public string Name { get; }

        public ApprovementParameters(IDateRange dateRange, string name)
        {
            DateRange = dateRange;
            Name = name;
        }
    }
}
