using System.Collections.Generic;

namespace ConsoleApp1
{
	internal class DummyEquipmentProvider: IEquipmentProvider
	{
		public DummyEquipmentProvider()
		{
		}

		ICollection<Equipment> IEquipmentProvider.LoadData()
		{
			return new[]
			{
				new Equipment(), 
				new Equipment()
			};
		}
	}
}