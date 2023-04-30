﻿using LKSandbox.Interfaces;
using LKSandbox.Interfaces.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LKSandbox.Models.Engine
{
    internal class EngineServiceType : IEngineServiceType
    {
        public int Code { get; }

        public string Name { get; }

        public string Description { get; }

        public EngineServiceType(int code, string name, string desc)
        {
            Code = code;
            Name = name;
            Description = desc;
        }

        public decimal BuildDuration<T>(T buildDurationDataProvider) where T : IBuildDurationDataProvider
        {
            return buildDurationDataProvider.ProvideData().Days;
        }

        public bool HasApprovalToBuild<T>(T approvementDataProvider) where T : IApprovementDataProvider
        {
            return approvementDataProvider.ProvideData().IsApproved;
        }

        public decimal TotalCost<T>(T totalCostDataProvider) where T : ITotalCostDataProvider
        {
            return totalCostDataProvider.ProvideData().TotalCost;
        }
    }
}
