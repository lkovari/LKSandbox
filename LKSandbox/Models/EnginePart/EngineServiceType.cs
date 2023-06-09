﻿using LKSandbox.Interfaces.DataProducers;
using LKSandbox.Interfaces.Engine;
using LKSandbox.Interfaces.Result;

namespace LKSandbox.Models.Engine
{
    public class EngineServiceType : IEngineServiceType
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

        public IBuildDurationData BuildDuration<T>(T buildDurationDataProducer) where T : IBuildDurationDataProducer
        {
            return buildDurationDataProducer.ProduceData(buildDurationDataProducer.DurationParameters);
        }

        public IApprovementData ApprovalToBuild<T>(T approvementDataProducer) where T : IApprovementDataProducer
        {
            return approvementDataProducer.ProduceData(approvementDataProducer.ApprovementParameters);
        }

        public ITotalCostData TotalCost<T>(T totalCostDataProducer) where T : ITotalCostDataProducer
        {
            return totalCostDataProducer.ProduceData(totalCostDataProducer.TotalCostParameters);
        }
        public override string ToString()
        {
            return "Name " + Name + " Code " + Code + " Description " + Description;
        }
    }
}
