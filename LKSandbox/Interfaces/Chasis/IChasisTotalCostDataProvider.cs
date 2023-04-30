namespace LKSandbox.Interfaces.Chasis
{
    internal interface IChasisTotalCostDataProvider : ITotalCostDataProvider
    {
        DateOnly Installation { get; }
    }
}
