namespace LKSandbox.Interfaces.Engine
{
    internal interface IEngineApprovementDataProvider : IApprovementDataProvider
    {
        public DateOnly Approvement { get; }
    }
}
