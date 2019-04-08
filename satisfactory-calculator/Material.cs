using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace satisfactory_calculator
{
	class Material
	{
		// Constructors
		public Material(string name)
		{
			new Material(name, 0);
		}
		public Material(string name, int qty)
		{
			new Material(name, new List<Material>(), qty);
		}
        public Material(string name, Material ingredient, int qty)
        {
            new Material(name, new List<Material> { ingredient }, qty);
        }
		public Material(string name, List<Material> ingredients, int qty)
		{
			Name = name;
			Ingredients = ingredients;
			Qty = qty;
		}


		// Private Properties
		string _name;
		int _qty;
		List<Material> _ingredients;


		// Public Properties
		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}
		public int Qty
		{
			get { return _qty; }
			set { _qty = value; }
		}
		public List<Material> Ingredients
		{
			get { return _ingredients; }
			set { _ingredients = value; }
		}


		// Method Overrides
		public override string ToString()
		{
			return Name;
		}
	}
}
