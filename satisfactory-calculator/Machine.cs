using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace satisfactory_calculator
{
	class Machine
	{
		// Constructors
		public Machine() { }
		public Machine(string name, int powerUsage, List<Material> ingredients)
		{
			Name = name;
			PowerUsage = powerUsage;
			Ingredients = ingredients;
		}
		public Machine(string name, Material inputMaterial, Material outputMaterial, int powerUsage, List<Material> ingredients)
		{
			Name = name;
			InputMaterials = new List<Material> { inputMaterial };
			OutputMaterial = outputMaterial;
			PowerUsage = powerUsage;
			Ingredients = ingredients;
		}
        public Machine(string name, List<Material> inputMaterials, Material outputMaterial, int powerUsage, List<Material> ingredients)
        {
            Name = name;
            InputMaterials = inputMaterials;
            OutputMaterial = outputMaterial;
            PowerUsage = powerUsage;
            Ingredients = ingredients;
        }

        // Private Properties
        string _name = string.Empty;
        List<Material> _inputMaterials = new List<Material>();
        Material _outputMaterial = new Material();
        int _powerUsage = 0;
        List<Material> _ingredients = new List<Material>();

		// Public Properties
		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}
		public List<Material> InputMaterials
		{
			get { return _inputMaterials; }
			set { _inputMaterials = value; }
		}
		public Material OutputMaterial
		{
			get { return _outputMaterial; }
			set { _outputMaterial = value; }
		}
		public int PowerUsage
		{
			get { return _powerUsage; }
			set { _powerUsage = value; }
		}
		public List<Material> Ingredients
		{
			get { return _ingredients; }
			set { _ingredients = value; }
		}


        public void addInputMaterial(Material inputMaterial, int qty)
        {
            _inputMaterials.Add(new Material(inputMaterial, qty));
        }
        public void addInputMaterial(List<Material> inputMaterials)
        {
            _inputMaterials.AddRange(inputMaterials);
        }

		// Method Overrides
		public override string ToString()
		{
			return Name;
		}

	}
}
