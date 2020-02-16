using System.Collections.Generic;

namespace ConsoleApp1
{
	interface IReportsExporter
	{
		void ExportReports(ICollection<Scenario> scenarioList);
	}
}