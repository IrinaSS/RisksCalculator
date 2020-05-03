using System;

namespace ConsoleApp1
{
	internal class ConsoleReportExporter: IReportExporter
	{
		
		void IReportExporter.Export(Report report)
		{
			Console.WriteLine(report);
		}
	}
}