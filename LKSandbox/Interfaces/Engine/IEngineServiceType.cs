namespace LKSandbox.Interfaces.Engine
{
    internal interface IEngineServiceType : IVehicleParts
    {
        int Code { get; }
        string Name { get; }
        string Description { get; }
    }
}
