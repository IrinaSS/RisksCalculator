using System.Collections.Generic;

namespace ConsoleApp1
{
	internal interface IReportProvider
	{
		Report GenerateReport(ICollection<Scenario> scenarioList);
	}
}