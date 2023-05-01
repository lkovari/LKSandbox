namespace LKSandbox.Interfaces.Parameters
{
    public interface IApprovementParameters : IParameters
    {
        IDateRange DateRange { get; }
    }
}
