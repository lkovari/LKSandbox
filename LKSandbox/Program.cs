using LKSandbox.Executor;
using LKSandbox.Interfaces;
using LKSandbox.Interfaces.DataProducers;
using LKSandbox.Interfaces.Parameters;
using LKSandbox.Models;
using LKSandbox.Models.Chasis;
using LKSandbox.Models.Engine;
using LKSandbox.Models.Parameters;
using System.Text.Json;

Console.WriteLine("C# Generic Interfaces practice example alias Hello, World!");
var vehicleAssemblyUnit = new VehicleAssemblyUnit<IVehiclePartType, IVehicleDataProducers>();

IVehiclePartType vehicleFrameworkEngine = new EngineServiceType(3475638, "Engine 1", "This is an Engine of Vehicle");

var approveDateEngine = new DateOnly(1965, 2, 2);
var dateRangeEngine = new DateRange(new DateOnly(1965, 2, 2), new DateOnly(1966, 12, 10));

IApprovementParameters engineApprovementParameters = new ApprovementParameters(dateRangeEngine, "Engine approvement parameters");
IApprovementDataProducer engineApprovementDataProducer = new EngineApprovementDataProducer(approveDateEngine, engineApprovementParameters);

IDurationParameters durationParameters = new DurationParameters(dateRangeEngine, "Engine duration parameters");
IBuildDurationDataProducer engineBuildDurationDataProducer = new EngineBuildDurationDataProducer(1965, durationParameters);

ITotalCostParameters totalCostParameters = new TotalCostParameters(dateRangeEngine, 1965, "Engine total cost parameters");
ITotalCostDataProducer engineTotalCostDataProducer = new EngineTotalCostDataProducer(approveDateEngine, totalCostParameters);

IVehicleDataProducers engineVehicleDataProducers = new VehicleDataProducers(engineApprovementDataProducer, engineBuildDurationDataProducer, engineTotalCostDataProducer);

var vehicleEngineAssembled = vehicleAssemblyUnit.VehicleBuilder(vehicleFrameworkEngine, engineVehicleDataProducers);

var vehicleEngineAssembledJson = JsonSerializer.Serialize(vehicleEngineAssembled);
Console.WriteLine($"{{\"Engine\":\"{vehicleEngineAssembledJson}\"}}");

IVehiclePartType vehicleFrameworkChasis = new ChasisServiceType("Chasis-Code", "Chasis 1", "This is an Chasis of Vehicle");

var approveDateChasis = new DateOnly(1966, 12, 10);
IApprovementParameters chasisApprovementParameters = new ApprovementParameters(dateRangeEngine, "Chasis approvement parameters");
IApprovementDataProducer chasisApprovementDataProducer = new ChasisApprovementDataProducer(approveDateChasis, chasisApprovementParameters);

IDurationParameters chasisDurationParameters = new DurationParameters(dateRangeEngine, "Chasis duration parameters");
IBuildDurationDataProducer chasisBuildDurationDataProducer = new ChasisBuildDurationDataProducer(1966, chasisDurationParameters);

ITotalCostParameters chasisTotalCostParameters = new TotalCostParameters(dateRangeEngine, 1965, "Chasis total cost parameters");
ITotalCostDataProducer chasisTotalCostDataProducer = new ChasisTotalCostDataProducer(approveDateChasis, chasisTotalCostParameters);

IVehicleDataProducers chasisVehicleDataProducers = new VehicleDataProducers(chasisApprovementDataProducer, chasisBuildDurationDataProducer, chasisTotalCostDataProducer);

var vehicleChasisAssembled = vehicleAssemblyUnit.VehicleBuilder(vehicleFrameworkEngine, chasisVehicleDataProducers);

var vehicleChasisAssembledJson = JsonSerializer.Serialize(vehicleChasisAssembled);
Console.WriteLine($"{{\"Chasis\":\"{vehicleChasisAssembledJson}\"}}");



