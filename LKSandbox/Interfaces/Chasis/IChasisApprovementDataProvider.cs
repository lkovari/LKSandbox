namespace LKSandbox.Interfaces.Chasis
{
    internal interface IChasisApprovementDataProvider : IApprovementDataProvider
    {
        public DateOnly Approvement { get; }
    }
}
