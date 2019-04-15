using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace satisfactory_calculator
{
	public class Material
	{
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


		// Public Properties
		public string Name;
		public double Qty;



		//public void IncreaseTotal(int amount)
		//{
		//	Qty = Qty * amount;
		//}
		public Material IncreaseTotal(Material material, int amount)
		{
			material.Qty = material.Qty * amount;
			return material;
		}
    }
}
