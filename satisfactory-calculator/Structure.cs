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
        public List<Material> Ingredients;

        public Structure() { }
        public Structure(string name)
        {
            Name = name;
        }
	}
}
