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

        private List<Material> _inputMaterials = new List<Material>();
        private Material _outputMaterial = new Material();

        List<Material> InputMaterials
        {
            get { return _inputMaterials; }
            set { _inputMaterials = value; }
        }
        Material OutputMaterial
        {
            get { return _outputMaterial; }
            set { _outputMaterial = value; }
        }

    }
}
