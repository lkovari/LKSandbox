namespace LKSandbox.Interfaces.Engine
{
    public interface IAssembledVehicleData
    {
        bool ApprovementData { get; }
        decimal BuildDurationData { get; }
        decimal TotalCostData { get; }
    }
}
