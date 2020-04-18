using System.Collections.Generic;

namespace ConsoleApp1
{
	internal class ScenarioBuilder: IScenarioBuilder
	{
		public ScenarioBuilder()
		{
		}

		ICollection<Scenario> IScenarioBuilder.BuildScenarios(ICollection<Equipment> equipments)
		{
			throw new System.NotImplementedException();
		}
	}
}