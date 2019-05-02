using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace satisfactory_calculator
{
	public partial class Machine : Structure
	{
        public double PowerUsage { get; set; }
        public Recipe CurrentRecipe { get; set; }
        public List<Recipe> AvailableRecipes { get; set; }
        [System.Xml.Serialization.XmlAttribute]
        public int Total { get; set; }
        public bool ShouldSerializeTotal() { return Total>1; }


        // Constructors
        public Machine()
        {
            Name = string.Empty;
            Ingredients = null;
            PowerUsage = 0;
            CurrentRecipe = null;
            AvailableRecipes = null;
            Total = 0;
        }
		public Machine(string name, List<Material> ingredients, double powerUsage, Recipe currentRecipe = null, List<Recipe> availableRecipes = null, int total = 0 )
		{
			Name = name;
			Ingredients = ingredients;
			PowerUsage = powerUsage;
			CurrentRecipe = currentRecipe;
            AvailableRecipes = availableRecipes;
            Total = total;
		}
		//public Machine(string name, List<Material> ingredients, double powerUsage, List<Recipe> availableRecipes)
		//{
		//	Name = name;
		//	Ingredients = ingredients;
		//	PowerUsage = powerUsage;
		//	AvailableRecipes = availableRecipes;
		//}
		//public Machine(string name, List<Material> ingredients, double powerUsage, List<Recipe> availableRecipes, Recipe recipe )
		//{
		//	Name = name;
		//	Ingredients = ingredients;
		//	PowerUsage = powerUsage;
		//	CurrentRecipe = recipe;
		//	AvailableRecipes = availableRecipes;
		//}

	}
}
