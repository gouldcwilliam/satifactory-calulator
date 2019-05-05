using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace satisfactory_calculator
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
            if (System.IO.File.Exists("trace.log"))
            {
                try { System.IO.File.Delete("trace.log"); }
                catch (Exception) {; }
            }
			Application.Run(new FormMain());
		}
	}
}
