using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace satisfactory_calculator.Materials
{
    static class Ores
    {
        public static Material IronOre = new Material("Iron Ore");
        public static Material CopperOre = new Material("Copper Ore");
        public static Material Limestone = new Material("Limestone");
        public static Material Coal = new Material("Coal");
        public static Material CrudeOil = new Material("Crude Oil");
        public static Material CateriumOre = new Material("Caterium Ore");
        public static Material RawQuartz = new Material("Raw Quartz");
        public static Material Sulfur = new Material("Sulfur");
        public static Material Bauxite = new Material("Bauxite");
        public static Material SAMOre = new Material("S.A.M. Ore");
        public static Material Silica = new Material("Silica");
        public static Material Uranium = new Material("Uranium");


        public static List<Material> ListAll = new List<Material>
        {
            IronOre,
            CopperOre,
            Limestone,
            Coal,
            CrudeOil,
            CateriumOre,
            RawQuartz,
            Sulfur,
            Bauxite,
            SAMOre,
            Silica,
            Uranium
        };

        //static List<Material> _listProperties()
        public static void _listProperties()
        {
            List<Material> returnList = new List<Material>();
            Material material = new Material();

            foreach(System.Reflection.FieldInfo field in Type.GetType("satisfactory_calculator.Materials.Ores").GetFields())
            {
                if (field.ToString().Contains("satisfactory_calculator.Material"))
                {
                    returnList.Add((Material)field.GetValue(material));
                }
            }
        }
    }
}
