using LKSandbox.Interfaces.Result;

namespace LKSandbox.Models.Result
{
    internal class ApprovementData : IApprovementData
    {
        public DateOnly Date { get; }

        public bool IsApproved { get; }

        public string Name { get; }

        public ApprovementData(string name, DateOnly date, bool approved)
        {
            Name = name;
            Date = date;
            IsApproved = approved;
        }
    }
}
