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
		public Material() {; }
		public Material(string name)
		{
			new Material(name, 0);
		}
		public Material(string name, int qty)
		{
			Name = name;
			Qty = qty;
		}

		// Private Properties
		string _name;
		int _qty;

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

		
	}
}
