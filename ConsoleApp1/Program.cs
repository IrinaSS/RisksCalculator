using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			//new ServiceCollection();
			var equipmentProvider = new EquipmentProvider();
			var scenarioBuilder = new ScenarioBuilder();
			var reportsExporter = new ReportsExporter();



			var calculator = new Calculator(equipmentProvider, scenarioBuilder, reportsExporter);
			calculator.Do();
		}

		//static IServiceCollection RegisterClasses(IServiceCollection services)

	}
}
