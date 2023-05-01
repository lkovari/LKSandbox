namespace LKSandbox.Interfaces.Chasis
{
    internal interface IChasisServiceType : IVehiclePartType
    {
        string Name { get; }
        string Description { get; }
        string ChasisNumber { get; }
    }
}
