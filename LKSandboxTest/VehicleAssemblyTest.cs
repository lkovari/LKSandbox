using FluentAssertions;
using LKSandbox.Executor;
using LKSandbox.Interfaces;
using LKSandbox.Interfaces.DataProducers;
using LKSandbox.Interfaces.Parameters;
using LKSandbox.Interfaces.Result;
using LKSandbox.Models;
using LKSandbox.Models.Chasis;
using LKSandbox.Models.Engine;
using LKSandbox.Models.Parameters;

namespace LKSandboxTest
{
    public class VehicleAssemblyTest
    {
        VehicleAssemblyUnit<IVehiclePartType, IVehicleDataProducers> vehicleAssemblyUnit;
        DateRange dateRange;

        // private const bool EXPECTED_ENGINE_APPROVEMENT_RESULT = true;
        private const decimal EXPECTED_ENGINE_BUILD_DURATION_RESULT = 1965;
        private const decimal EXPECTED_ENGINE_TOTAL_COST_RESULT = 1328340;
        // private const bool EXPECTED_CHASIS_APPROVEMENT_RESULT = true;
        private const decimal EXPECTED_CHASIS_BUILD_DURATION_RESULT = 1966;
        private const decimal EXPECTED_CHASIS_TOTAL_COST_RESULT = 1329016;

        [SetUp]
        public void Setup()
        {
            vehicleAssemblyUnit = new VehicleAssemblyUnit<IVehiclePartType, IVehicleDataProducers>();
            dateRange = new DateRange(new DateOnly(1965, 2, 2), new DateOnly(1966, 12, 10));
        }

        [Test]
        public void EngineTypeTest()
        {
            var approveDateEngine = new DateOnly(1965, 2, 2);
            IVehiclePartType vehicleFrameworkEngine = new EngineServiceType(3475638, "Engine 1", "This is an Engine of Vehicle");

            IApprovementParameters approvementParameters = new ApprovementParameters(dateRange, "Engine approvement parameters");
            IApprovementDataProducer engineApprovementDataProducer = new EngineApprovementDataProducer(approveDateEngine, approvementParameters);

            IDurationParameters durationParameters = new DurationParameters(dateRange, "Engine duration parameters");
            IBuildDurationDataProducer engineBuildDurationDataProducer = new EngineBuildDurationDataProducer(1965, durationParameters);

            ITotalCostParameters totalCostParameters = new TotalCostParameters(dateRange, 1965, "Engine total cost parameters");
            ITotalCostDataProducer engineTotalCostDataProducer = new EngineTotalCostDataProducer(approveDateEngine, totalCostParameters);

            IVehicleDataProducers engineVehicleDataProducers = new VehicleDataProducers(engineApprovementDataProducer, engineBuildDurationDataProducer, engineTotalCostDataProducer);

            var vehicleEngineAssembled = vehicleAssemblyUnit.VehicleBuilder(vehicleFrameworkEngine, engineVehicleDataProducers);
            vehicleEngineAssembled.ApprovementData.Should().NotBeNull();
            ((IApprovementData)vehicleEngineAssembled.ApprovementData).IsApproved.Should().BeTrue();
            vehicleEngineAssembled.BuildDurationData.Should().NotBeNull();
            ((IBuildDurationData)vehicleEngineAssembled.BuildDurationData).Days.Should().Be(EXPECTED_ENGINE_BUILD_DURATION_RESULT);
            vehicleEngineAssembled.TotalCostData.Should().NotBeNull();
            ((ITotalCostData)vehicleEngineAssembled.TotalCostData).TotalCost.Should().Be(EXPECTED_ENGINE_TOTAL_COST_RESULT);
        }

        [Test]
        public void ChasisTypeTest()
        {
            var approveDateEngine = new DateOnly(1966, 12, 10);
            IVehiclePartType vehicleFrameworkEngine = new ChasisServiceType("Chasis 1", "Chasis 1 description", "This is a Chasis of Vehicle");

            IApprovementParameters approvementParameters = new ApprovementParameters(dateRange, "Chasis approvement parameters");
            IApprovementDataProducer chasisApprovementDataProducer = new ChasisApprovementDataProducer(approveDateEngine, approvementParameters);

            IDurationParameters durationParameters = new DurationParameters(dateRange, "Chasis duration parameters");
            IBuildDurationDataProducer chasisBuildDurationDataProducer = new ChasisBuildDurationDataProducer(19661965, durationParameters);

            ITotalCostParameters totalCostParameters = new TotalCostParameters(dateRange, 1966, "Chasis total cost parameters");
            ITotalCostDataProducer chasisTotalCostDataProducer = new ChasisTotalCostDataProducer(approveDateEngine, totalCostParameters);

            IVehicleDataProducers engineVehicleDataProducers = new VehicleDataProducers(chasisApprovementDataProducer, chasisBuildDurationDataProducer, chasisTotalCostDataProducer);

            var vehicleChasisAssembled = vehicleAssemblyUnit.VehicleBuilder(vehicleFrameworkEngine, engineVehicleDataProducers);
            vehicleChasisAssembled.ApprovementData.Should().NotBeNull();
            ((IApprovementData)vehicleChasisAssembled.ApprovementData).IsApproved.Should().BeFalse();
            vehicleChasisAssembled.BuildDurationData.Should().NotBeNull();
            ((IBuildDurationData)vehicleChasisAssembled.BuildDurationData).Days.Should().Be(EXPECTED_CHASIS_BUILD_DURATION_RESULT);
            vehicleChasisAssembled.TotalCostData.Should().NotBeNull();
            ((ITotalCostData)vehicleChasisAssembled.TotalCostData).TotalCost.Should().Be(EXPECTED_CHASIS_TOTAL_COST_RESULT);
        }
    }
}