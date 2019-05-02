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
        public double Qty = 0;
        [System.Xml.Serialization.XmlIgnore]
        public string Category = string.Empty;


		// Constructors
        public Material() {; }
		public Material(string name)
		{
            Name = name;
		}
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
