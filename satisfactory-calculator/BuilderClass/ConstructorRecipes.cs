using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace satisfactory_calculator.BuilderClass
{
	public static class ConstructorRecipes
	{
		public static Recipe IronPlate = new Recipe(Components.IronPlate, 15, Components.IronIngot, 30);
		public static Recipe IronRod = new Recipe(Components.IronRod, 15, Components.IronIngot, 15);
		public static Recipe Wire = new Recipe(Components.Wire, 45, Components.CopperIngot, 15);
		public static Recipe WireAlt1 = new Recipe(Components.Wire, 45, Components.IronIngot, 15);
		public static Recipe WireAlt2 = new Recipe(Components.Wire, 67.5, Components.CateriumIngot, 7.5);
		public static Recipe Cable = new Recipe(Components.Cable, 15, Components.Wire, 30);
		public static Recipe BiomassLeaves = new Recipe("Biomass (Leaves)", Components.Biomass, 90, Components.Leaves, 10);
		public static Recipe BiomassWood = new Recipe("Biomass (Wood)", Components.Biomass, 375, Components.Wood, 75);
		public static Recipe BiomassMycelia = new Recipe("Biomas (Mycelia)", Components.Biomass, 150, Components.Mycelia, 150);
		public static Recipe BiomassCarpace = new Recipe("Biomas (Carpace)", Components.Biomass, 150, Components.Carpace, 150);
		public static Recipe Concrete = new Recipe(Components.Concrete, 15, Ores.Limestone, 45);
		public static Recipe Screw = new Recipe(Components.Screw, 90, Components.IronIngot, 15);
		public static Recipe ScrewAlt1 = new Recipe(Components.Screw, 90, Components.IronRod, 15);
		public static Recipe PowerShardGreen = new Recipe(Components.PowerShard, 6, Components.GreenPowerSlug, 6);
		public static Recipe PowerShardYellow = new Recipe(Components.PowerShard, 6, Components.YellowPowerSlug, 6);
		public static Recipe PowerShardPurple = new Recipe(Components.PowerShard, 6, Components.PurplePowerSlug, 6);
		public static Recipe BioFuel = new Recipe(Components.BioFuel, 30, Components.Biomass, 60);
		public static Recipe SteelBeam = new Recipe(Components.SteelBeam, 10, Components.SteelIngot, 30);
		public static Recipe SteelPipe = new Recipe(Components.SteelPipe, 15, Components.SteelIngot, 15);
		public static Recipe ColorCartridge = new Recipe(Components.ColorCartridge, 75, Components.FlowerPetals, 37.5);
		public static Recipe SpikeRebar = new Recipe(Components.SpikedRebar, 15, Components.IronRod, 15);
		public static Recipe QuickWire = new Recipe(Components.QuickWire, 60, Components.CateriumIngot, 15);


		public static List<Recipe> GetRecipes()
		{
			return new List<Recipe>
			{
				IronPlate,
				IronRod,
				Wire,
				Cable,
				BiomassLeaves,
				Concrete,
				Screw,
				BiomassWood,

				//
				//
				//
				SteelBeam,
				SteelPipe
				//
				//
				//
				//
			};
		}
	}
}
