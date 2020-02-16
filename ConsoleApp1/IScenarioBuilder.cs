using System.Collections.Generic;

namespace ConsoleApp1
{
	interface IScenarioBuilder
	{
		ICollection<Scenario> BuildScenarios(ICollection<Equipment> equipments);
	}
}