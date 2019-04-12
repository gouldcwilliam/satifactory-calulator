using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace satisfactory_calculator.Recipes
{
    static class Smelter
    {
        public static Recipe IronIngots = new Recipe(new Material(Materials.Components.IronIngot, 30), new Material(Materials.Ores.IronOre, 30));
        public static Recipe CopperIngots = new Recipe(new Material(Materials.Components.CopperIngot, 30), new Material(Materials.Ores.CopperOre, 30));
        public static Recipe CateriumIngot = new Recipe(new Material(Materials.Components.CateriumIngot, 30), new Material(Materials.Ores.CateriumOre, 30));
    }
}
