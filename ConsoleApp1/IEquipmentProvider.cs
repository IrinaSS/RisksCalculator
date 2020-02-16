using System.Collections.Generic;

namespace ConsoleApp1
{
	interface IEquipmentProvider
	{
		ICollection<Equipment> LoadData();
	}
}