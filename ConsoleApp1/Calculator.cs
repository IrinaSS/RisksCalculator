using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
	class Calculator : ICalculator
	{
		public Calculator(IEquipmentProvider equipmentProvider, IScenarioBuilder scenarioBuilder, IReportsExporter reportsExporter)
		{
			EquipmentProvider = equipmentProvider;
			ScenarioBuilder = scenarioBuilder;
			ReportsExporter = reportsExporter;
		}

		public void Do()
		{
			var equipmentList = EquipmentProvider.LoadData();

			var scenarioList = ScenarioBuilder.BuildScenarios(equipmentList);

			foreach (var scenario in scenarioList)
				scenario.Calculate();

			ReportsExporter.ExportReports(scenarioList);
		}

		IEquipmentProvider EquipmentProvider { get; }
		IScenarioBuilder ScenarioBuilder { get; }
		IReportsExporter ReportsExporter { get; }
	}
}
