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
        [System.Xml.Serialization.XmlElement]
        public string Name { get; set; }
        public bool ShouldSerializeName() { return !string.IsNullOrEmpty(Name); }

        [System.Xml.Serialization.XmlElement]
        public double Qty { get; set; }
        public bool ShouldSerializeQty() { return Qty > 0; }

        [System.Xml.Serialization.XmlIgnore] 
        public string Category;
        

		// Constructors
        public Material() { Name=string.Empty; Qty = 0; }
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
        
        public bool IsEmpty()
        {
            return ((Name == string.Empty) && (Qty == 0));
        }
    }
}
