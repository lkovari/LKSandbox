using LKSandbox.Interfaces.Chasis;
using LKSandbox.Interfaces.DataProducers;
using LKSandbox.Interfaces.Result;

namespace LKSandbox.Models.Chasis
{
    public class ChasisServiceType : IChasisServiceType
    {
        public string Name { get; }

        public string Description { get; }

        public string ChasisNumber { get; }

        public ChasisServiceType(string name, string desc, string chasisNum)
        {
            Name = name;
            Description = desc;
            ChasisNumber = chasisNum;
        }

        public IResultData BuildDuration<T>(T buildDurationDataProducer) where T : IBuildDurationDataProducer
        {
            return buildDurationDataProducer.ProduceData(buildDurationDataProducer.DurationParameters);
        }

        public IResultData HasApprovalToBuild<T>(T approvementDataProducer) where T : IApprovementDataProducer
        {
            return approvementDataProducer.ProduceData(approvementDataProducer.ApprovementParameters);
        }

        public IResultData TotalCost<T>(T totalCostDataProducer) where T : ITotalCostDataProducer
        {
            return totalCostDataProducer.ProduceData(totalCostDataProducer.TotalCostParameters);
        }
    }
}
