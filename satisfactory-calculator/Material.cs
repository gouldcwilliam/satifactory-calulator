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
            Name = name;
		}
		public Material(string name, int qty)
		{
            Name = name;
            Qty = qty;
		}
        public Material(string name, Material ingredient)
        {
            Name = name;
            Ingredients = new List<Material> { ingredient };
        }
        public Material(string name, Material ingredient, int qty)
        {
            Name = name;
            Ingredients = new List<Material> { ingredient };
            Qty = qty;
        }
        public Material(string name, List<Material> ingredients)
        {
            Name = name;
            Ingredients = ingredients;
        }
		public Material(string name, List<Material> ingredients, int qty)
		{
			Name = name;
			Ingredients = ingredients;
			Qty = qty;
		}
        public Material(Material material, int qty)
        {
            Name = material.Name;
            Qty = qty;
            Ingredients = material.Ingredients;
        }
        public Material(Material material, List<Material> ingredients)
        {
            Name = material.Name;
            Qty = material.Qty;
            Ingredients = ingredients;
        }
        public Material(Material material, List<Material> ingredients, int qty)
        {
            Name = material.Name;
            Qty = qty;
            Ingredients = ingredients;
        }


        // Private Properties
        string _name = string.Empty;
        int _qty = 0;
        List<Material> _ingredients = new List<Material>();


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

        public override string ToString()
        {
            return Name;
        }


    }
}
