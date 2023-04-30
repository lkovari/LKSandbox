namespace LKSandbox.Interfaces.Chasis
{
    internal interface IChasisServiceType : IVehicleParts
    {
        string Name { get; }
        string Description { get; }
        string ChasisNumber { get; }
    }
}
