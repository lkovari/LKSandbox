namespace LKSandbox.Interfaces
{
    internal interface IBuildDurationData
    {
        string Name { get; }
        DateOnly BuildDate { get; }
        decimal Days { get; }
    }
}
