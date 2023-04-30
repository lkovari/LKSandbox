using LKSandbox.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LKSandbox.Models
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
    }
}
