using System.Collections.Generic;

namespace ConsoleApp1
{
	internal class ReportsExporter: IReportsExporter
	{
		public ReportsExporter()
		{
		}

		void IReportsExporter.ExportReports(ICollection<Scenario> scenarioList)
		{
			throw new System.NotImplementedException();
		}
	}
}