using LKSandbox.Executor;
using LKSandbox.Interfaces;
using LKSandbox.Models;
using LKSandbox.Models.Chasis;
using LKSandbox.Models.Engine;
using System.Text.Json;

Console.WriteLine("C# Generic Interfaces practice example alias Hello, World!");
var vehicleAssemblyUnit = new VehicleAssemblyUnit<IVehicleParts, IVehicleDataProviders>();

IVehicleParts vehicleFrameworkEngine = new EngineServiceType(3475638, "Engine 1", "This is an Engine of Vehicle");

var approveDateEngine = new DateOnly(1965, 2, 2);
IApprovementDataProvider engineApprovementDataProvider = new EngineApprovementDataProvider(approveDateEngine);
IBuildDurationDataProvider engineBuildDurationDataProvider = new EngineBuildDurationDataProvider(1965);
ITotalCostDataProvider engineTotalCostDataProvider = new EngineTotalCostDataProvider(approveDateEngine);
IVehicleDataProviders engineVehicleDataProviders = new VehicleDataProviders(engineApprovementDataProvider, engineBuildDurationDataProvider, engineTotalCostDataProvider);
var vehicleEngineAssembled = vehicleAssemblyUnit.VehicleBuilder(vehicleFrameworkEngine, engineVehicleDataProviders);

var vehicleEngineAssembledJson = JsonSerializer.Serialize(vehicleEngineAssembled);
Console.WriteLine($"{{\"Engine\":\"{vehicleEngineAssembledJson}\"}}");

IVehicleParts vehicleFrameworkChasis = new ChasisServiceType("Chasis-Code", "Chasis 1", "This is an Chasis of Vehicle");

var approveDateChasis = new DateOnly(1966, 12, 10);
IApprovementDataProvider chasisApprovementDataProvider = new ChasisApprovementDataProvider(approveDateChasis);
IBuildDurationDataProvider chasisBuildDurationDataProvider = new ChasisBuildDurationDataProvider(1966);
ITotalCostDataProvider chasisTotalCostDataProvider = new ChasisTotalCostDataProvider(approveDateChasis);
IVehicleDataProviders chasisVehicleDataProviders = new VehicleDataProviders(chasisApprovementDataProvider, chasisBuildDurationDataProvider, chasisTotalCostDataProvider);
var vehicleChasisAssembled = vehicleAssemblyUnit.VehicleBuilder(vehicleFrameworkEngine, chasisVehicleDataProviders);

var vehicleChasisAssembledJson = JsonSerializer.Serialize (vehicleChasisAssembled);
Console.WriteLine($"{{\"Chasis\":\"{vehicleChasisAssembledJson}\"}}");



