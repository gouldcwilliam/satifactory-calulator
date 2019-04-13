using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace satisfactory_calculator.Recipes
{
    static class Smelter
    {
		static Smelter()
		{
			Recipes = new List<Recipe>
			{
				IronIngots,
				CopperIngots,
				CateriumIngot
			};
		}
		public static List<Recipe> Recipes;

        public static Recipe IronIngots = new Recipe("Iron Ingots", new Material(Materials.Components.IronIngot, 30), new Material(Materials.Ores.IronOre, 30));
        public static Recipe CopperIngots = new Recipe("Copper Ingots", new Material(Materials.Components.CopperIngot, 30), new Material(Materials.Ores.CopperOre, 30));
        public static Recipe CateriumIngot = new Recipe("Caterium Ingots", new Material(Materials.Components.CateriumIngot, 60), new Material(Materials.Ores.CateriumOre, 15));
    }
}
