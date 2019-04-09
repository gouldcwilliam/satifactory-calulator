using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace satisfactory_calculator.Materials
{
	class Items
	{
		public List<Material> FloraAndFauna;
		public List<Material> HealingItems;
		public List<Material> OtherResources;
		public List<Material> Components;
		public List<Material> Tools;


		public Items()
		{
			//Ores = _getOreList();
			FloraAndFauna = _getFloraAndFauna_List();
			HealingItems = _getHealingItems_List();
			OtherResources = _getOtherResources_List();
			Components = _getComponents_List();
			Tools = _getTools_List();
		}

		// Ores



		// todo add FloraAndFauna
		List<Material> _getFloraAndFauna_List()
		{
			return new List<Material>();
		}
		// todo add HealingItems
		List<Material> _getHealingItems_List()
		{
			return new List<Material>();
		}
		// todo add OtherResources
		List<Material> _getOtherResources_List()
		{
			return new List<Material>();
		}

		// Components
		//public static readonly Material IronIngot = new Material("Iron Ingot", IronOre, 1);
		//public static readonly Material IronPlate = new Material("Iron Plate", IronIngot, 2);
		//public static readonly Material IronRod = new Material("Iron Rod", IronIngot, 1);
		//public static readonly Material CopperIngot = new Material("Copper Ingot", CopperOre, 1);
		//public static readonly Material Wire = new Material("Wire", CopperIngot, 1);
		//public static readonly Material Cable = new Material("Cable", Wire, 2);
		//public static readonly Material Biomass = new Material("Biomass");
		//public static readonly Material Concrete = new Material("Concrete", Limestone, 3);
		//public static readonly Material Screw = new Material("Screw", IronRod, 1);
		//public static readonly Material ReinforcedIronPlate = new Material("Reinforece Iron Plate", IronPlate, 4, Screw, 24);
		//public static readonly Material Rotor = new Material("Rotor", IronRod, 3, Screw, 22);
		//public static readonly Material ModularFrame = new Material("Modular Frame", ReinforcedIronPlate, 3, IronRod, 6);
		//public static readonly Material SteelIngot = new Material("Steel Ingot", IronOre, 3, Coal, 3);
		//public static readonly Material SteelBeam = new Material("Steel Beam", SteelIngot, 3);
		//public static readonly Material SteelPipe = new Material("Steel Pipe", SteelIngot, 1);
		//public static readonly Material EncasedIndustrialBeam = new Material("Encased Industrial Beam", SteelBeam, 4, Concrete, 5);

		List<Material> _getComponents_List()
		{
			return new List<Material>
			{
				//IronIngot,
				//IronPlate,
				//IronRod,
				//CopperIngot,
				//Wire,
				//Cable,
				//Biomass,
				//Concrete,
				//Screw,
				//ReinforcedIronPlate,
				//Rotor,
				//ModularFrame,
				//SteelIngot,
				//SteelBeam,
				//SteelPipe,
				//EncasedIndustrialBeam
			};
		}

		// todo add Tools
		List<Material> _getTools_List()
		{
			return new List<Material>();
		}
	}
}
