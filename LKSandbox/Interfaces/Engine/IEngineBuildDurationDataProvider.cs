namespace LKSandbox.Interfaces.Engine
{
    internal interface IEngineBuildDurationDataProvider : IBuildDurationDataProvider
    {
        decimal EngineSpecificBuildNumber { get; }
    }
}
