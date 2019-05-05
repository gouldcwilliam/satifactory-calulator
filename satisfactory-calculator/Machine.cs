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
        [System.Xml.Serialization.XmlElement]
        public Recipe CurrentRecipe { get; set; }
        public bool ShouldSerializeCurrentRecipe()
        {
            return CurrentRecipe == new Recipe();
        }

        [System.Xml.Serialization.XmlAttribute]
        public int Total { get; set; }
        public bool ShouldSerializeTotal() { return Total>1; }


        // Constructors
        public Machine()
        {
            Name = string.Empty;
            Ingredients = new List<Material>();
            PowerUsage = 0;
            CurrentRecipe = new Recipe();
            Total = 0;
        }
		public Machine(string name, List<Material> ingredients, double powerUsage, Recipe currentRecipe = null, int total = 0 )
		{
			Name = name;
			Ingredients = ingredients;
			PowerUsage = powerUsage;
			CurrentRecipe = currentRecipe;
            //AvailableRecipes = availableRecipes;
            Total = total;
		}

        public double GetOutputRecipeTotal()
        {
       
            return this.CurrentRecipe.OutputMaterial.Qty * this.Total;
        }


	}
}
