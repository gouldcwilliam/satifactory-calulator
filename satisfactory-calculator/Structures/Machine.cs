using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace satisfactory_calculator
{
	public partial class Machine : Structure
	{
		// Constructors
		public Machine() { }
		public Machine(string name, List<Material> ingredients, int powerUsage)
		{
			Name = name;
			PowerUsage = powerUsage;
			Ingredients = ingredients;
		}
		public Machine(string name, List<Material> ingredients, int powerUsage, Recipe recipe)
		{
			Name = name;
			Ingredients = ingredients;
			PowerUsage = powerUsage;
			Recipe = recipe;
		}


        public int PowerUsage;
        public Recipe Recipe;
        //public List<Recipe>
		// Method Overrides
		public override string ToString()
		{
			return Name;
		}

	}
}
