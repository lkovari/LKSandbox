using LKSandbox.Interfaces;

namespace LKSandbox.Models
{
    internal class ApprovementData : IApprovementData
    {
        public DateOnly Date { get; }

        public bool IsApproved { get; }

        public ApprovementData(DateOnly date, bool approved)
        {
            Date = date;
            IsApproved = approved;
        }
    }
}
