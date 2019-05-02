using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace satisfactory_calculator
{
	class Functions
	{
        /// <summary>
        /// Logs input to the trace.log file
        /// </summary>
        /// <param name="FormattedString"></param>
		public static void myLog(string FormattedString)
		{
			System.Diagnostics.Trace.WriteLine(FormattedString);
		}

        /// <summary>
        /// Logs input to the trace.log file
        /// </summary>
        /// <param name="IdentifierString"></param>
        /// <param name="machine"></param>
        public static void myLog(string IdentifierString, Machine machine)
		{
			string message =  string.Format("{0}:\n - Name: {1}\n - Ingredients: {2}\n - Power Usage: {3}\n - Current Recipe: {4}\n - Available Recipes: {5}\n - Total: {6}",
				IdentifierString, machine.Name, machine.Ingredients.Count, machine.PowerUsage, machine.CurrentRecipe.Name, machine.AvailableRecipes.Count, machine.Total);
			System.Diagnostics.Trace.WriteLine(message);
		}



	}
}
