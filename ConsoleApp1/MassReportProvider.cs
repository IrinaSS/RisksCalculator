using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
	internal class MassReportProvider : IReportProvider
	{
		Report IReportProvider.GenerateReport(ICollection<Scenario> scenarioList)
		{
			var massReport = new MassReport();
			var equipments = scenarioList.Select(scenario => scenario.Equipment).Distinct();
			foreach (var equipment in equipments)
				foreach (var substance in equipment.Substances)
				massReport.AddRow(
					equipmentName: equipment.Name,
					substanceName: substance.Type.Name,
					substanceName: substance.Mass.ToString());

			return massReport;
		}
	}
}