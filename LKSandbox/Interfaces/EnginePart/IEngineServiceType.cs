namespace LKSandbox.Interfaces.Engine
{
    internal interface IEngineServiceType : IVehiclePartType
    {
        int Code { get; }
        string Name { get; }
        string Description { get; }
    }
}
