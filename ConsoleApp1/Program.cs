using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			//	var services = new ServiceCollection();

			//RegisterServices(services);
			var reportProvider = new MassReportProvider();
			var reportExporter = new ConsoleReportExporter();
			var equipmentProvider = new DummyEquipmentProvider();
			var scenarioBuilder = new ScenarioBuilder();
			var reportsExporter = new ReportsExporter(new[] { reportProvider }, reportExporter);

			var calculator = new Calculator(equipmentProvider, scenarioBuilder, reportsExporter);
			calculator.Do();
		}

		//private static IServiceCollection RegisterServices(IServiceCollection services)
		//{
		//	return services
		//		.AddSingleton<IEquipmentProvider, EquipmentProvider>()
		//		.AddSingleton<IScenarioBuilder, ScenarioBuilder>()
		//		.AddSingleton<IReportsExporter, ReportsExporter>()
		//		.AddSingleton<ICalculator, Calculator>()
		//	;
		//}

		//static IServiceCollection RegisterClasses(IServiceCollection services)

	}
}
