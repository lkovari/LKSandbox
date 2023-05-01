namespace LKSandbox.Interfaces.Parameters
{
    public interface ITotalCostParameters : IParameters
    {
        IDateRange DateRange { get; }
        decimal DailyCosts { get; }
    }
}
