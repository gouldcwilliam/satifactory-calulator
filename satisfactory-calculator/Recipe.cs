using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace satisfactory_calculator
{
    public class Recipe
    {
		public string Name = string.Empty;
        public Material OutputMaterial = new Material();
        public List<Material> InputMaterials = new List<Material>();
        [System.Xml.Serialization.XmlIgnore]
        public string Parent = string.Empty;

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
		public Recipe(Material material, Material outputMaterial, List<Material> inputMaterials)
		{
			Name = material.Name;
			OutputMaterial = outputMaterial;
			InputMaterials = inputMaterials;
		}
		public Recipe(string name, Material outputMaterial, double outputQty, Material input1, int qty1, Material input2 = null, double qty2 = 0, Material input3 = null, double qty3 = 0, Material input4 = null, double qty4 = 0 )
		{
			Name = name;
			OutputMaterial = new Material(outputMaterial, outputQty);
			if ((input1 != null) && (qty1 > 0)) { InputMaterials.Add(new Material(input1.Name, qty1)); }
			if ((input2 != null) && (qty2 > 0)) { InputMaterials.Add(new Material(input2.Name, qty2)); }
			if ((input3 != null) && (qty3 > 0)) { InputMaterials.Add(new Material(input3.Name, qty3)); }
			if ((input4 != null) && (qty4 > 0)) { InputMaterials.Add(new Material(input4.Name, qty4)); }
		}
		public Recipe(Material outputMaterial, double outputQty, Material input1, double qty1,Material input2 = null, double qty2 = 0, Material input3 = null, double qty3 = 0, Material input4 = null, double qty4 = 0)
		{
			Name = outputMaterial.Name;
			OutputMaterial = new Material(outputMaterial, outputQty);
			if ((input1 != null) && (qty1 > 0)) { InputMaterials.Add(new Material(input1, qty1)); }
			if ((input2 != null) && (qty2 > 0)) { InputMaterials.Add(new Material(input2, qty2)); }
			if ((input3 != null) && (qty3 > 0)) { InputMaterials.Add(new Material(input3, qty3)); }
			if ((input4 != null) && (qty4 > 0)) { InputMaterials.Add(new Material(input4, qty4)); }
		}

	}
}
