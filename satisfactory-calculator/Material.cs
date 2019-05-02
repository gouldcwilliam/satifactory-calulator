using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace satisfactory_calculator
{
	public class Material
	{
        // Public Properties
        public string Name = string.Empty;

        public double Qty;
        public bool ShouldSerializeQty() { return Qty == 0; }

        [System.Xml.Serialization.XmlIgnore] 
        public string Category;
        

		// Constructors
        public Material() {; }
		public Material(string name, double qty)
		{
            Name = name;
            Qty = qty;
		}
        public Material(Material material, double qty)
        {
            Name = material.Name;
            Qty = qty;
        }
        
    }
}
