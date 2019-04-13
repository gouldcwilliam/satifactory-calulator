using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace satisfactory_calculator.Materials
{
    static class Components
    {
        static Components()
        {
            ListAll = new List<Material>
            {
                IronIngot,
                IronPlate,
                IronRod,
                CopperIngot,
                Wire,
                Cable,
                Biomass,
                Concrete,
                Screw,
                ReinforcedIronPlate,
                Rotor,
                ModularFrame,
                SteelIngot,
                SteelBeam,
                SteelPipe,
                EncasedIndustrialBeam
            };
        }

        public static List<Material> ListAll;

        public static Material IronIngot = new Material("Iron Ingot", new Material(Ores.IronOre, 1));
        public static Material IronPlate = new Material("Iron Plate", IronIngot, 2);
        public static Material IronRod = new Material("Iron Rod", IronIngot, 1);
        public static Material CopperIngot = new Material("Copper Ingot", Ores.CopperOre, 1);
        public static Material Wire = new Material("Wire", CopperIngot, 1);
        public static Material Cable = new Material("Cable", Wire, 2);
        public static Material Biomass = new Material("Biomass");
        public static Material Concrete = new Material("Concrete", Ores.Limestone, 3);
        public static Material Screw = new Material("Screw", IronRod, 1);
        public static Material ReinforcedIronPlate = new Material("Reinforece Iron Plate", new List<Material> { new Material(IronPlate, 4), new Material(Screw, 24) });
        public static Material Rotor = new Material("Rotor", new List<Material> { new Material(IronRod, 3), new Material(Screw, 22) });
        public static Material ModularFrame = new Material("Modular Frame", new List<Material> { new Material(ReinforcedIronPlate, 3), new Material(IronRod, 6) });
        public static Material SteelIngot = new Material("Steel Ingot", new List<Material> { new Material(Ores.IronOre, 3), new Material(Ores.Coal, 3) });
        public static Material SteelBeam = new Material("Steel Beam", SteelIngot, 3);
        public static Material SteelPipe = new Material("Steel Pipe", SteelIngot, 1);
        public static Material EncasedIndustrialBeam = new Material("Encased Industrial Beam", new List<Material> { new Material(SteelBeam, 4), new Material(Concrete, 5) });
        public static Material CateriumIngot = new Material("Caterium Ingot", Ores.CateriumOre, 1);

    }
}
