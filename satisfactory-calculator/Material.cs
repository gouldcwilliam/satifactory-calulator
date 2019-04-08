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
		public Material() { }
		public Material(string name)
		{
			new Material(name, 0);
		}
		public Material(string name, int qty)
		{
			new Material(name, new List<Material>(), qty);
		}
		public Material(string name, List<Material> ingredients, int qty)
		{
			Name = name;
			Ingredients = ingredients;
			Qty = qty;
		}

		/// <summary>
		/// Creates new Material with new quantity
		/// </summary>
		/// <param name="material"></param>
		/// <param name="qty"></param>
		public Material(Material material, int qty)
		{
			new Material(material.Name, qty);
		}
		public Material(string name, Material ing1, int qty1)
		{
			List<Material> ingredients = new List<Material>
			{
				new Material(ing1, qty1)
			};
			new Material(name, ingredients, 0);
		}
		public Material(string name, Material ing1, int qty1, Material ing2, int qty2)
		{
			List<Material> ingredients = new List<Material>
			{
				new Material(ing1, qty1),
				new Material(ing2, qty2)
			};
			new Material(name, ingredients, 0);
		}
		public Material(string name, Material ing1, int qty1, Material ing2, int qty2, Material ing3, int qty3)
		{
			List<Material> ingredients = new List<Material>
			{
				new Material(ing1, qty1),
				new Material(ing2, qty2),
				new Material(ing3, qty3)
			};
			new Material(name, ingredients, 0);
		}
		public Material(string name, Material ing1, int qty1, Material ing2, int qty2, Material ing3, int qty3, Material ing4, int qty4)
		{
			List<Material> ingredients =  new List<Material>
			{
				new Material(ing1, qty1),
				new Material(ing2, qty2),
				new Material(ing3, qty3),
				new Material(ing4, qty4),
			};
			new Material(name, ingredients, 0);
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
