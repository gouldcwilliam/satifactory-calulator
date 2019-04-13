using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace satisfactory_calculator.BuilderClass
{
	public static class SmelterRecipes
	{
		public static Recipe IronIngots = new Recipe(Components.IronIngot, 30, Ores.IronOre, 30);
		public static Recipe CopperIngots = new Recipe(Components.CopperIngot, 30, Ores.CopperOre, 30);
		public static Recipe CateriumIngot = new Recipe(Components.CateriumIngot, 60, Ores.CateriumOre, 15);
		
		public static List<Recipe> GetRecipes()
		{
			return new List<Recipe>
			{
				IronIngots,
				CopperIngots,
				CateriumIngot
			};
		}
	}
}
