using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace satisfactory_calculator.BuilderClass
{
    public static class ManufacturerRecipes
    {
        private static List<Recipe> _recipes()
        {
            string recipesFile = "MFRecipes.xml";
            if (!System.IO.File.Exists(recipesFile)) { return new List<Recipe>(); }
            return Functions.ReadFromXmlFile<List<Recipe>>(recipesFile);
        }

        public static List<Recipe> GetRecipes()
        {
            return _recipes();
        }
    }
}
