using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace satisfactory_calculator.BuilderClass
{
	public static class Machines
	{

		public static Machine Smelter()
		{
			string name = "Smelter";
			List<Material> ingredients = new List<Material>
			{
				new Material(Components.IronRod, 5),
				new Material(Components.Wire, 8)
			};
			int powerUsage = 4;
			List<Recipe> availableRecipes = SmelterRecipes.GetRecipes();
			Recipe recipe = new Recipe();
			return new Machine(name, ingredients, powerUsage, availableRecipes, recipe);
		}
		public static Machine Constructor()
		{
			string name = "Constructor";
			List<Material> ingredients = new List<Material>
			{
				new Material(Components.ReinforcedIronPlate, 3),
				new Material(Components.Cable, 2)
			};
			int powerUsage = 4;
			List<Recipe> availableRecipes = ConstructorRecipes.GetRecipes();
			Recipe recipe = new Recipe();
			return new Machine(name, ingredients, powerUsage, availableRecipes, recipe);
		}

        public static Machine Manufacturer()
        {
            string name = "Manufacturer";
            int powerUsage = 55;
            List<Material> ingredients = new List<Material>
                {
                    new Material("Heavy Modular Frame", 2),
                    new Material("Motor", 2),
                    new Material("Cable", 25),
                    new Material("Computer", 3)
                };
            List<Recipe> availableRecipes = ManufacturerRecipes.GetRecipes();
            Recipe recipe = new Recipe();
            return new Machine(name, ingredients, powerUsage, availableRecipes, recipe);

        }
    

        //	new List<Material> {
        //		new Material("Portable Miner", 1),
        //		new Material("Iron Rod", 5),
        //		new Material("Concrete", 5)
        //	};
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
        //public static Machine Assembler = new Machine("Assembler", 15,
        //	new List<Material>
        //	{
        //		new Material("Modular Frame", 3),
        //		new Material("Rotor", 4),
        //		new Material("Cable", 10),
        //	});


        public static List<Machine> GetMachines()
		{
			return new List<Machine>
			{
				//MinerMk1,
				//MinerMk2,
				//OilPump,
				Smelter(),
				//Foundry,
				//OilRefinery,
				Constructor(),
				//Assembler,
				Manufacturer()
            };
		}
	}
}

