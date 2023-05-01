using LKSandbox.Interfaces.Result;

namespace LKSandbox.Models.Result
{
    internal class BuildDurationData : IBuildDurationData
    {
        public string Name { get; }

        public DateOnly BuildDate { get; }

        public decimal Days { get; }

        public BuildDurationData(string name, DateOnly build, decimal days)
        {
            Name = name;
            BuildDate = build;
            Days = days;
        }

        public override string ToString()
        {
            return Name + " " + BuildDate.ToString() + " " + Days;
        }
    }
}
