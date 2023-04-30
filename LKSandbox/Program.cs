// See https://aka.ms/new-console-template for more information
using LKSandbox.Executor;
using LKSandbox.Interfaces;
using LKSandbox.Models;

Console.WriteLine("Hello, World!");
var vehicleAssemblyUnit = new VehicleAssemblyUnit<EngineServiceType>();
IVehicleFramework vehicleFrameworkEngine = new EngineServiceType("ENGINE-Code", "Engine 1", "This is an Engine of Vehicle");
vehicleAssemblyUnit.VehicleBuilder(vehicleFrameworkEngine);

/*
var vehicleAssemblyUnit = new VehicleAssemblyUnit<ChasisServiceType>();
IVehicleFramework vehicleFrameworkChasis = new ChasisServiceType("ENGINE-Code", "Engine 1", "This is an Engine of Vehicle");
vehicleAssemblyUnit.VehicleBuilder(vehicleFrameworkChasis);
*/


