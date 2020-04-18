using System.Collections.Generic;

namespace ConsoleApp1
{
	internal class EquipmentProvider: IEquipmentProvider
	{
		public EquipmentProvider()
		{
		}

		ICollection<Equipment> IEquipmentProvider.LoadData()
		{
			throw new System.NotImplementedException();
		}
	}
}