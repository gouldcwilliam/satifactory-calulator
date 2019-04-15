using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace satisfactory_calculator
{
    public class Structure
    {
        public string Name = string.Empty;
        public List<Material> Ingredients = new List<Material>();

        public Structure() { }
        public Structure(string name)
        {
            Name = name;
        }
		
		//public Structure IncreaseTotal(Structure structure, int amount)

		//{
		//	structure.Ingredients.ForEach(x =>x= x.IncreaseTotal(x,amount));
		//	return structure;
		//}
	}
}
