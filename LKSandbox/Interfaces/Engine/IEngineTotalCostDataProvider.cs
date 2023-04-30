namespace LKSandbox.Interfaces.Engine
{
    internal interface IEngineTotalCostDataProvider : ITotalCostDataProvider
    {
        DateOnly Installation { get; }
    }
}
