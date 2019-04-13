using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace satisfactory_calculator.BuilderClass
{
    public static class Components
    {
        public static Material IronIngot = new Material("Iron Ingot");
        public static Material IronPlate = new Material("Iron Plate");
        public static Material IronRod = new Material("Iron Rod");
        public static Material CopperIngot = new Material("Copper Ingot");
        public static Material Wire = new Material("Wire");
        public static Material Cable = new Material("Cable");
        public static Material Biomass = new Material("Biomass");
        public static Material Concrete = new Material("Concrete");
        public static Material Screw = new Material("Screw");
        public static Material ReinforcedIronPlate = new Material("Reinforeced Iron Plate");
        public static Material Rotor = new Material("Rotor");
        public static Material ModularFrame = new Material("Modular Frame");
        public static Material SteelIngot = new Material("Steel Ingot");
        public static Material SteelBeam = new Material("Steel Beam");
        public static Material SteelPipe = new Material("Steel Pipe");
        public static Material EncasedIndustrialBeam = new Material("Encased Industrial Beam");
        public static Material CateriumIngot = new Material("Caterium Ingot");
		public static Material Leaves = new Material("Leaves");
		public static Material Wood = new Material("Wood");
		public static Material Mycelia = new Material("Mycelia");
		public static Material FlowerPetals = new Material("Flower Petals");
		public static Material ColorCartridge = new Material("Color Cartridge");
		public static Material SpikedRebar = new Material("Spike Rebar");
		public static Material QuickWire = new Material("Quickwire");
		public static Material BioFuel = new Material("Biofuel");
		public static Material GreenPowerSlug = new Material("Green Power Slug");
		public static Material YellowPowerSlug = new Material("Yellow Power Slug");
		public static Material PurplePowerSlug = new Material("Purple Power Slug");
		public static Material PowerShard = new Material("Power Shard");
		public static Material Carpace = new Material("Carpace");

		public static List<Material> GetMaterials()
        {
            return new List<Material>
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
                EncasedIndustrialBeam,
				CateriumIngot,
				Leaves,
				Wood,
				Mycelia,
				FlowerPetals,
				ColorCartridge,
				SpikedRebar,
				QuickWire,
				BioFuel,
				GreenPowerSlug,
				YellowPowerSlug,
				PurplePowerSlug,
				PowerShard,
				Carpace
            };
        }

    }
}
