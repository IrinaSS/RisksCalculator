using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
	internal class ReportsExporter: IReportsExporter
	{
		public ReportsExporter(IEnumerable<IReportProvider> reportProviders, IReportExporter reportExporter)
		{
			ReportProviders = reportProviders.ToArray();
			ReportExporter = reportExporter;
		}

		IReportProvider[] ReportProviders { get; }
		IReportExporter ReportExporter { get; }

		void IReportsExporter.ExportReports(ICollection<Scenario> scenarioList)
		{
			var reports = ReportProviders.Select(provider => provider.GenerateReport(scenarioList));
			foreach (var report in reports)
				ReportExporter.Export(report);

			Console.WriteLine($"рассчитано сценариев : {scenarioList.Count}");
		}
	}
}