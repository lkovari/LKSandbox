using FluentAssertions;
using LKSandbox.Executor;
using LKSandbox.Interfaces;
using LKSandbox.Models;
using LKSandbox.Models.Chasis;
using LKSandbox.Models.Engine;

namespace LKSandboxTest
{
    public class VehicleAssemblyTest
    {
        VehicleAssemblyUnit<IVehicleParts, IVehicleDataProviders> vehicleAssemblyUnit;
        // private const bool EXPECTED_ENGINE_APPROVEMENT_RESULT = true;
        private const decimal EXPECTED_ENGINE_BUILD_DURATION_RESULT = 1965;
        private const decimal EXPECTED_ENGINE_TOTAL_COST_RESULT = 19651966;
        // private const bool EXPECTED_CHASIS_APPROVEMENT_RESULT = true;
        private const decimal EXPECTED_CHASIS_BUILD_DURATION_RESULT = 1966;
        private const decimal EXPECTED_CHASIS_TOTAL_COST_RESULT = 19661965;

        [SetUp]
        public void Setup()
        {
            vehicleAssemblyUnit = new VehicleAssemblyUnit<IVehicleParts, IVehicleDataProviders>();
        }

        [Test]
        public void EngineTypeTest()
        {
            var approveDateEngine = new DateOnly(1965, 2, 2);
            IVehicleParts vehicleFrameworkEngine = new EngineServiceType(3475638, "Engine 1", "This is an Engine of Vehicle");
            IApprovementDataProvider engineApprovementDataProvider = new EngineApprovementDataProvider(approveDateEngine);
            IBuildDurationDataProvider engineBuildDurationDataProvider = new EngineBuildDurationDataProvider(1965);
            ITotalCostDataProvider engineTotalCostDataProvider = new EngineTotalCostDataProvider(approveDateEngine);

            IVehicleDataProviders engineVehicleDataProviders = new VehicleDataProviders(engineApprovementDataProvider, engineBuildDurationDataProvider, engineTotalCostDataProvider);

            var vehicleEngineAssembled = vehicleAssemblyUnit.VehicleBuilder(vehicleFrameworkEngine, engineVehicleDataProviders);
            vehicleEngineAssembled.ApprovementData.Should().BeTrue();
            vehicleEngineAssembled.BuildDurationData.Should().Be(EXPECTED_ENGINE_BUILD_DURATION_RESULT);
            vehicleEngineAssembled.TotalCostData.Should().Be(EXPECTED_ENGINE_TOTAL_COST_RESULT);
        }

        [Test]
        public void ChasisTypeTest()
        {
            var approveDateEngine = new DateOnly(1966, 12, 10);
            IVehicleParts vehicleFrameworkEngine = new ChasisServiceType("Chasis 1", "Chasis 1 description", "This is a Chasis of Vehicle");
            IApprovementDataProvider chasisApprovementDataProvider = new ChasisApprovementDataProvider(approveDateEngine);
            IBuildDurationDataProvider chasisBuildDurationDataProvider = new ChasisBuildDurationDataProvider(19661965);
            ITotalCostDataProvider chasisTotalCostDataProvider = new ChasisTotalCostDataProvider(approveDateEngine);

            IVehicleDataProviders engineVehicleDataProviders = new VehicleDataProviders(chasisApprovementDataProvider, chasisBuildDurationDataProvider, chasisTotalCostDataProvider);

            var vehicleEngineAssembled = vehicleAssemblyUnit.VehicleBuilder(vehicleFrameworkEngine, engineVehicleDataProviders);
            vehicleEngineAssembled.ApprovementData.Should().BeFalse();
            vehicleEngineAssembled.BuildDurationData.Should().Be(EXPECTED_CHASIS_BUILD_DURATION_RESULT);
            vehicleEngineAssembled.TotalCostData.Should().Be(EXPECTED_CHASIS_TOTAL_COST_RESULT);
        }
    }
}