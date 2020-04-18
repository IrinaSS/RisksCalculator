using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
	internal class ScenarioBuilder: IScenarioBuilder
	{
		public ScenarioBuilder()
		{
		}

		ICollection<Scenario> IScenarioBuilder.BuildScenarios(ICollection<Equipment> equipments)
		{
			return equipments
				.Select(equipment => new Scenario(equipment))
				.ToArray();
		}
	}
}