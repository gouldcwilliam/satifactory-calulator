using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace satisfactory_calculator.Structures
{
	static class Machines
	{

        static Machines()
        {
            ListAll = new List<Machine>
            {
                //MinerMk1,
                //MinerMk2,
                //OilPump,
                //Smelter,
                //Foundry,
                //OilRefinery,
                //Constructor,
                //Assembler,
                //Manufacturer
            };
        }
        public static List<Machine> ListAll;

		// Public Static Read Onlys
		//public static Machine MinerMk1 = new Machine("Miner Mk.1", 5,
		//	new List<Material> {
		//		new Material("Portable Miner", 1),
		//		new Material("Iron Rod", 5),
		//		new Material("Concrete", 5)
		//	});
		//public static Machine MinerMk2 = new Machine("Miner Mk.2", 12,
		//	new List<Material>
		//	{
		//		new Material("Portable Miner", 1),
		//		new Material("Encased Industrial Beam", 4),
		//		new Material("Steel Pipe", 10),
		//		new Material("Cable", 10)
		//	});
		//public static Machine OilPump = new Machine("Oil Pump", 0,
		//	new List<Material>
		//	{
		//		new Material("Heavy Modular Frame", 2),
		//		new Material("Motor", 3),
		//		new Material("Cable", 10)
		//	});
		//public static Machine Smelter = new Machine("Smelter", 4, Recipes.Smelter.IronIngots,
		//	new List<Material>
		//	{
		//		new Material("Iron Rod", 5),
		//		new Material("Wire", 8)
		//	});
		//public static Machine Foundry = new Machine("Foundry", 16,
		//	new List<Material>
		//	{
		//		new Material("Encased Industrial Beam", 3),
		//		new Material("Steel Pipe", 14),
		//		new Material("Concrete", 8)
		//	});
		//public static Machine OilRefinery = new Machine("Oil Refinery", 50,
		//	new List<Material>
		//	{
		//		new Material("Heavy Modular Frame", 2),
		//		new Material("Motor", 5),
		//		new Material("Steel Pipe", 20),
		//		new Material("Cable", 20)
		//	});
		//public static Machine Constructor = new Machine("Constructor", 4,
		//	new List<Material>
		//	{
		//		new Material("Reinforced Iron Plate", 3),
		//		new Material("Cable", 2)
		//	});
		//public static Machine Assembler = new Machine("Assembler", 15,
		//	new List<Material>
		//	{
		//		new Material("Modular Frame", 3),
		//		new Material("Rotor", 4),
		//		new Material("Cable", 10),
		//	});
		//public static Machine Manufacturer = new Machine("Manufacturer", 55,
		//	new List<Material>
		//	{
		//		new Material("Heavy Modular Frame", 2),
		//		new Material("Motor", 2),
		//		new Material("Cable", 25),
		//		new Material("Computer", 3)
		//	});
	}
}

