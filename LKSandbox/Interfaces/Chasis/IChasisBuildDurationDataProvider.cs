namespace LKSandbox.Interfaces.Chasis
{
    internal interface IChasisBuildDurationDataProvider : IBuildDurationDataProvider
    {
        decimal ChasisSpecificBuildNumber { get; }
    }
}
