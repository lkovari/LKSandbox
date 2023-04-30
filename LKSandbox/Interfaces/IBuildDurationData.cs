namespace LKSandbox.Interfaces
{
    public interface IBuildDurationData
    {
        string Name { get; }
        DateOnly BuildDate { get; }
        decimal Days { get; }
    }
}
