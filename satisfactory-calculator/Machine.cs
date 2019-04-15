using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace satisfactory_calculator
{
	public partial class Machine : Structure
	{
        public double PowerUsage;
        public Recipe CurrentRecipe;
		public List<Recipe> AvailableRecipes;
		public int Total = 1;

		// Constructors
		public Machine() { }
		public Machine(string name, List<Material> ingredients, double powerUsage)
		{
			Name = name;
			PowerUsage = powerUsage;
			Ingredients = ingredients;
		}
		public Machine(string name, List<Material> ingredients, double powerUsage, Recipe recipe)
		{
			Name = name;
			Ingredients = ingredients;
			PowerUsage = powerUsage;
			CurrentRecipe = recipe;
		}
		public Machine(string name, List<Material> ingredients, double powerUsage, List<Recipe> availableRecipes)
		{
			Name = name;
			Ingredients = ingredients;
			PowerUsage = powerUsage;
			AvailableRecipes = availableRecipes;
		}
		public Machine(string name, List<Material> ingredients, double powerUsage, List<Recipe> availableRecipes, Recipe recipe )
		{
			Name = name;
			Ingredients = ingredients;
			PowerUsage = powerUsage;
			CurrentRecipe = recipe;
			AvailableRecipes = availableRecipes;
		}


		//public Machine IncreaseTotal(Machine machine, int amount)
		//{
		//	machine.Ingredients.ForEach(x => x = x.IncreaseTotal(x,amount));
		//	machine.PowerUsage = machine.PowerUsage * amount;
		//	machine.CurrentRecipe = machine.CurrentRecipe.IncreaseTotal(machine.CurrentRecipe, amount);
		//	machine.AvailableRecipes.ForEach(x => x= x.IncreaseTotal(x,amount));
		//	return machine;
		//}

	}
}
