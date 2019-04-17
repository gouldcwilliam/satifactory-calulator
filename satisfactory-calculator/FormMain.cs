using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;


namespace satisfactory_calculator
{
	public partial class FormMain : Form
	{
        /* Declarations */
		List<Machine> _MyMachines = new List<Machine>();
        List<TotalInOut> _TotalsInOut = new List<TotalInOut>();

        /* Main Constructor */
		public FormMain()
		{
			InitializeComponent();

            //_InitializeSettings();

			pictureBoxSatisfactoryIcon.BringToFront();
			pictureBoxSatisfactoryIcon.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBoxSatisfactoryIcon.Image = Image.FromFile("../../Images/Satisfactory-original.png");

            BuilderClass.Machines.GetMachines().ForEach(m => comboBoxMachine.Items.Add(m.Name));
			comboBoxMachine.SelectedIndex = 0;

            BuilderClass.Components.GetMaterials().ForEach(m => _TotalsInOut.Add(new TotalInOut(m)));
            BuilderClass.Ores.GetMaterials().ForEach(m => _TotalsInOut.Add(new TotalInOut(m)));
            _TotalInOut_RefreshAll();
		}


        /* Top Panel Stuff */

        #region For custom mousedown*/
        const int WM_NCLBUTTONDOWN = 0xA1;
        const int HTCAPTION = 0x2;
        [DllImport("User32.dll")]
        static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        static extern int SendMessage(System.IntPtr hWnd, int Msg, int wParam, int lParam);
        #endregion
        private void panelClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void panelMaximize_Click(object sender, EventArgs e)
		{
			if (WindowState == FormWindowState.Maximized)
			{
				panelMaximize.BackgroundImage = global::satisfactory_calculator.Properties.Resources.maximize_16x16;
				WindowState = FormWindowState.Normal;
			}
			else if (WindowState == FormWindowState.Normal)
			{
				this.WindowState = FormWindowState.Maximized;
				this.panelMaximize.BackgroundImage = global::satisfactory_calculator.Properties.Resources.restore_16x16_grey;
			}

		}

        private void panelMinimize_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void panelButton_MouseEnter(object sender, EventArgs e)
		{
			try
			{
				System.Windows.Forms.Panel panel = (System.Windows.Forms.Panel)sender;
				if (panel == panelClose )
				{
					panelClose.BackColor = System.Drawing.Color.Red;
				}
				else
				{
					panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
				}
			}
			catch (Exception ex) { Console.WriteLine(ex.Message); }
		}

		private void panelButton_MouseLeave(object sender, EventArgs e)
		{
			try
			{
				System.Windows.Forms.Panel panel = (System.Windows.Forms.Panel)sender;
				panel.BackColor = System.Drawing.SystemColors.Control;
			}
			catch (Exception ex) { Console.WriteLine(ex.Message); }
		}

		private void panelTop_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				ReleaseCapture();
				SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
			}
		}


        /* TEXT INPUT */


        private void comboBoxMachine_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxResource.Items.Clear();
            foreach (Recipe recipe in BuilderClass.Machines.GetMachines().Find(x => x.Name == comboBoxMachine.Text).AvailableRecipes)
            {
                Trace.WriteLine(string.Format("BuilderClass.Machines.GetMachines(): Recipe.Name:\n - {0}\n", recipe.Name));
                comboBoxResource.Items.Add(recipe.Name);
            }
            comboBoxResource.SelectedIndex = 0;
        }

        private void comboBoxMachine_TextChanged(object sender, EventArgs e)
        {
            Trace.WriteLine(string.Format("comboBoxMachine.Text:\n - {0}\n", comboBoxMachine.Text));
        }

        private void numericUpDownQty_ValueChanged(object sender, EventArgs e)
        {
            Trace.WriteLine(string.Format("numericUpDownQty.Value:\n - {0}\n", numericUpDownQty.Value.ToString()));
        }

        private void comboBoxResource_TextChanged(object sender, EventArgs e)
        {
            Trace.WriteLine(string.Format("comboBoxResource.Text:\n - {0}\n", comboBoxResource.Text));
        }



        /* BUTTON METHODS */


        private void buttonAdd_Click(object sender, EventArgs e)
		{
			if (!comboBoxMachine.Items.Contains(comboBoxMachine.Text))
			{
				MessageBox.Show(string.Format("Invalid Machine: ' {0} '", comboBoxMachine.Text));
				return;
			}

			if (!(101 > numericUpDownQty.Value) && (numericUpDownQty.Value > 0))
			{
				MessageBox.Show(string.Format("Invalid Qty: {0}", numericUpDownQty.Value));
				return;
			}

			if (!comboBoxResource.Items.Contains(comboBoxResource.Text))
			{
				MessageBox.Show(string.Format("Invalid Resource: ' {0} '", comboBoxResource.Text));
				return;
			}

            // finds matching machine using the selected machine
			Machine machine = BuilderClass.Machines.GetMachines().Find(x => x.Name == comboBoxMachine.Text);
            // finds matching recipe using the selected resource
			machine.CurrentRecipe = machine.AvailableRecipes.Find(x => x.Name == comboBoxResource.Text);
            // sets the total # of machines to add
			machine.Total = (int)numericUpDownQty.Value;
			_MyMachines_AddMachine(machine);

            Functions.myLog("MyMachines.Add(machine):\n - ", machine);
		}

		private void buttonEdit_Click(object sender, EventArgs e)
		{
            WriteAllXMLs();
            test();
			return;
		}



        /* LIST'S METHODS, FUNCTIONS, HANDLERS */



        /// <summary>
        /// adds Machine to _MyMachine while factoring in the total property of the machine
        /// ensures the input and output of the machine supplied is used
        /// </summary>
        /// <param name="machine"></param>
        private void _MyMachines_AddMachine(Machine machine)
        {
            _MyMachines.Add(machine);
            dgvMachines.Rows.Add(dgvMachines.Rows.Count, machine.Name, machine.Total, machine.CurrentRecipe.Name, machine.CurrentRecipe.OutputMaterial.Qty * machine.Total);

            Functions.myLog("_MyMachines.Add(machine):\n - ", machine);
            Functions.myLog("dataGridViewMachines.Rows.Add(machine):\n - {0}", machine);

            foreach(Material material in machine.CurrentRecipe.InputMaterials)
            {
                _TotalInOut_UpdateInputQty(material, machine.Total);
            }
            _TotalInOut_UpdateOutputQty(machine.CurrentRecipe.OutputMaterial, machine.Total);
            _TotalInOut_RefreshAll();
            return;
        }
        /// <summary>
        /// finds matching material in list and updates the input qty
        /// material.Qty * machine.Total
        /// </summary>
        /// <param name="material">material to update</param>
        /// <param name="machineTotal">used to factor the qty increased</param>
        private void _TotalInOut_UpdateInputQty(Material material, int machineTotal)
        {
            foreach (TotalInOut total in _TotalsInOut)
            {
                if (total.Material.Name != material.Name) continue;
                total.Input = total.Input + (material.Qty * machineTotal);
            }
        }

        /// <summary>
        /// finds matching material in list and updates the ouptut qty
        /// material.Qty * machine.Total
        /// </summary>
        /// <param name="material">material to update</param>
        /// <param name="machineTotal">used to factor the qty increased</param>
        private void _TotalInOut_UpdateOutputQty(Material material, int machineTotal)
        {
            foreach (TotalInOut total in _TotalsInOut)
            {
                if (total.Material.Name != material.Name) continue;
                total.Output = total.Output + (material.Qty * machineTotal);
            }
        }
        /// <summary>
        /// Refreshes Global Totals (data grid view) when the totalinout list is updated
        /// </summary>
		private void _TotalInOut_RefreshAll()
		{
            DataGridView dgv = dgvGlobalTotals;
            dgv.Rows.Clear();
            foreach (TotalInOut total in _TotalsInOut)
            {
                if(total.Input==0 && total.Output==0) { continue; }
                dgv.Rows.Add(total.Material.Name, total.Output, total.Input);
            }
            dgvGlobalTotals = dgv;
		}




        /// <summary>
        /// Writes all my helper/builder classes to xml file during development phase
        /// </summary>
		private void WriteAllXMLs()
        {
			Functions.WriteToXmlFile<List<Machine>>("Machines.xml", BuilderClass.Machines.GetMachines());
            Functions.WriteToXmlFile<List<Recipe>>("ConstructorRecipes.xml", BuilderClass.ConstructorRecipes.GetRecipes());
            Functions.WriteToXmlFile<List<Material>>("Components.xml", BuilderClass.Components.GetMaterials());
            Functions.WriteToXmlFile<List<Material>>("Ores.xml", BuilderClass.Ores.GetMaterials());
            Functions.WriteToXmlFile<List<Recipe>>("SmelterRecipes.xml", BuilderClass.SmelterRecipes.GetRecipes());
        }

        private void dataGridViewMachines_SelectionChanged(object sender, EventArgs e)
		{
			if (!(dgvMachines.SelectedRows.Count > 0)) { return; }

			int index = dgvMachines.SelectedRows[0].Index;
			dgvUsage.Rows.Clear();
			foreach (Material material in _MyMachines[index].CurrentRecipe.InputMaterials)
			{
				dgvUsage.Rows.Add(material.Name, material.Qty * _MyMachines[index].Total);
				Functions.myLog(string.Format("dgvUsage.Rows.Add(material.Name, material.Qty * _MyMachines[index].Total): - {0}\n - {1}", material.Name, material.Qty));
			}
			Functions.myLog(string.Format("dataGridViewMachines.SelectedRows[0].Index:\n - {0}", index.ToString()));
			Functions.myLog("MyMachines[index]", _MyMachines[index]);

			dgvUsage.Refresh();
		}


        /* TESTING */
        private void test()
        {

            List<Material> materials = XMLSettings.Components;
            return;
        }

	}
}
