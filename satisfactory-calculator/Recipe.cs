using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace satisfactory_calculator
{
    public class Recipe
    {
        public Recipe()
        {
            ;
        }
		public Recipe(string name, Material outputMaterial, Material inputMaterial)
		{
			Name = name;
			OutputMaterial = outputMaterial;
			InputMaterials = new List<Material> { inputMaterial };
		}
        public Recipe(string name, Material outputMaterial, List<Material> inputMaterials)
        {
            Name = name;
            OutputMaterial = outputMaterial;
            InputMaterials = inputMaterials;
        }

        public string Name = string.Empty;
        public List<Material> InputMaterials = new List<Material>();
        public Material OutputMaterial = new Material();


    }
}
