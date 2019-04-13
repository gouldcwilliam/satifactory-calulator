using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace satisfactory_calculator
{
    class Recipe
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
		public Recipe(Material outputMaterial, Material inputMaterial)
        {
            OutputMaterial = outputMaterial;
            InputMaterials = new List<Material> { inputMaterial };
        }
        public Recipe(Material outputMaterial, List<Material> inputMaterials)
        {
            OutputMaterial = outputMaterial;
            InputMaterials = inputMaterials;
        }

		private string _name = string.Empty;
        private List<Material> _inputMaterials = new List<Material>();
        private Material _outputMaterial = new Material();

		public string Name
		{
			get { return _name; }
			set { _name = Name; }
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


    }
}
