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
        // TODO - dgvMachines - Add
        //      make last row of dgvMachines editable ie:column 1 dropdown, etc

        // TODO - dgvMachines - Edit
        //      make edit button click allow changes to current row in dgvMachines



        /* Declarations */
        List<Machine> _AddedMachines = new List<Machine>();
        // container for the total material usages for all items
        List<TotalInOut> _AddedMachineTotals = new List<TotalInOut>();
        public List<Machine> _newMachines = new List<Machine>();

        /* Main Constructor */
		public FormMain()
		{
			InitializeComponent();

            // Reads the settings file
            XMLSettings.ReadAll();
            testControlsVisible();
            //_InitializeSettings();
            pictureBoxSatisfactoryIcon.BringToFront();
			pictureBoxSatisfactoryIcon.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBoxSatisfactoryIcon.Image = Image.FromFile("../../Images/Satisfactory-original.png");

            // Binds the data sources to their perspective datagridviews
            //dgvMachines.DataSource = bindingSource_Machines;
            //dgvUsage.DataSource = bindingSource_Recipes;

            // For each machine in XMLSettings.AllMachines Add the Machine to the drop down box
            XMLSettings.AllMachines.ForEach(m => comboBoxMachine.Items.Add(m.Name));
			if(comboBoxMachine.Items.Count>0) comboBoxMachine.SelectedIndex = 0;
            
            // loops through available materials and adds them to totals list
            XMLSettings.AllMaterials.ForEach(m => _AddedMachineTotals.Add(new TotalInOut(m)));
            _AddedMachineTotals_RefreshAll();
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
            comboBoxRecipe.Items.Clear();
            if (comboBoxMachine.Text == string.Empty) { return; }

            foreach(Recipe recipe in XMLSettings.AllRecipes.FindAll(m=>m.Parent==comboBoxMachine.Text))
            {
                comboBoxRecipe.Items.Add(recipe.Name);
            }

            if (comboBoxRecipe.Items.Count > 0) comboBoxRecipe.SelectedIndex = 0;
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
            Trace.WriteLine(string.Format("comboBoxResource.Text:\n - {0}\n", comboBoxRecipe.Text));
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

			if (!comboBoxRecipe.Items.Contains(comboBoxRecipe.Text))
			{
				MessageBox.Show(string.Format("Invalid Resource: ' {0} '", comboBoxRecipe.Text));
				return;
			}

            // finds matching machine using the selected machine
			Machine machine = XMLSettings.AllMachines.Find(x => x.Name == comboBoxMachine.Text);
            // finds matching recipe using the selected resource
            machine.CurrentRecipe = XMLSettings.AllRecipes.Find(x => x.Name == comboBoxRecipe.Text);
            // sets the total # of machines to add
			machine.Total = (int)numericUpDownQty.Value;
			_AddedMachines_AddMachine(machine);

            Functions.myLog("MyMachines.Add(machine):\n - ", machine);
		}

		private void buttonEdit_Click(object sender, EventArgs e)
		{
            if (!(dgvMachines.SelectedRows.Count > 0)) { return; }
            comboBoxMachine.SelectedItem = dgvMachines.SelectedRows[0].Cells[columnMachinesMachine.Name].Value;
		}



        /* LIST'S METHODS, FUNCTIONS, HANDLERS */



        /// <summary>
        /// adds Machine to _AddedMachines while factoring in the total property of the machine
        /// ensures the input and output of the machine supplied is used
        /// </summary>
        /// <param name="machine"></param>
        private void _AddedMachines_AddMachine(Machine machine)
        {
            numericUpDownQty.Value = numericUpDownQty.Minimum;

            _AddedMachines.Add(machine);

            //dgvMachines.Rows.Add(dgvMachines.Rows.Count, machine.Name, machine.Total, machine.CurrentRecipe.Name, machine.CurrentRecipe.OutputMaterial.Qty * machine.Total);
            dgvMachines.Rows.Add(machine.Name, machine.Total, machine.CurrentRecipe.Name, machine.GetOutputRecipeTotal(), machine.CurrentRecipe);

            Functions.myLog("_MyMachines.Add(machine):\n - ", machine);
            Functions.myLog("dataGridViewMachines.Rows.Add(machine):\n - {0}", machine);

            foreach(Material material in machine.CurrentRecipe.InputMaterials)
            {
                _AddedMachineTotals_UpdateInputQty(material, machine.Total);
            }
            _AddedMachineTotals_UpdateOutputQty(machine.CurrentRecipe.OutputMaterial, machine.Total);
            _AddedMachineTotals_RefreshAll();
            return;
        }
        /// <summary>
        /// finds matching material in list and updates the input qty
        /// material.Qty * machine.Total
        /// </summary>
        /// <param name="material">material to update</param>
        /// <param name="machineTotal">used to factor the qty increased</param>
        private void _AddedMachineTotals_UpdateInputQty(Material material, int machineTotal)
        {
            foreach (TotalInOut total in _AddedMachineTotals.FindAll(m=>m.Material.Name==material.Name))
            {
                total.Input = total.Input + (material.Qty * machineTotal);
            }
        }

        /// <summary>
        /// finds matching material in list and updates the ouptut qty
        /// material.Qty * machine.Total
        /// </summary>
        /// <param name="material">material to update</param>
        /// <param name="machineTotal">used to factor the qty increased</param>
        private void _AddedMachineTotals_UpdateOutputQty(Material material, int machineTotal)
        {
            foreach (TotalInOut total in _AddedMachineTotals)
            {
                if (total.Material.Name != material.Name) continue;
                total.Output = total.Output + (material.Qty * machineTotal);
            }
        }
        /// <summary>
        /// Refreshes Global Totals (data grid view) when the totalinout list is updated
        /// </summary>
		private void _AddedMachineTotals_RefreshAll()
		{
            DataGridView dgv = dgvGlobalTotals;
            dgv.Rows.Clear();
            foreach (TotalInOut total in _AddedMachineTotals)
            {
                if(total.Input==0 && total.Output==0) { continue; }
                dgv.Rows.Add(total.Material.Name, total.Output, total.Input);
            }
            dgvGlobalTotals = dgv;
		}






        private void dataGridViewMachines_SelectionChanged(object sender, EventArgs e)
		{
            // sanity checks
			if (!(dgvMachines.SelectedRows.Count > 0)) { return; }

            dgvUsage.Rows.Clear();

            // get data from selected row
            int machineQty = (int)dgvMachines.SelectedRows[0].Cells[columnMachinesQty.Name].Value;
            Recipe currentRecipe =(Recipe)dgvMachines.SelectedRows[0].Cells[columnMachinesCurrentRecipe.Index].Value;

            foreach (Material material in currentRecipe.InputMaterials)
            {
                dgvUsage.Rows.Add(material.Name, material.Qty * machineQty);
            }
            dgvUsage.Refresh();

        }


        /* TESTING */
        private void testControlsVisible()
        {
            buttonReadConf.Visible = Debugger.IsAttached;
            buttonWriteConf.Visible = Debugger.IsAttached;
            buttonReadTest.Visible = Debugger.IsAttached;
            buttonWriteTest.Visible = Debugger.IsAttached;
            button1.Visible = Debugger.IsAttached;
            button2.Visible = Debugger.IsAttached;
            button3.Visible = Debugger.IsAttached;
        }

        private void ButtonReadConf_Click(object sender, EventArgs e)
        {
            XMLSettings.ReadAll();
        }

        private void ButtonWriteConf_Click(object sender, EventArgs e)
        {
            XMLSettings.WriteAll();
        }

        private void ButtonReadTest_Click(object sender, EventArgs e)
        {
            XMLSettings.ReadAll("Test");
        }

        private void ButtonWriteTest_Click(object sender, EventArgs e)
        {
            XMLSettings.WriteAll("Test");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            XMLSettings.WriteToXmlFile<List<Machine>>("test.xml", _newMachines);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Forms.EditSettings editSettings = new Forms.EditSettings();
            if (editSettings.ShowDialog() == DialogResult.OK)
            {
                if (editSettings.Machine.Name != string.Empty) { _newMachines.Add(editSettings.Machine); }
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            List<Machine> machines = XMLSettings.AllMachines;
            foreach(Machine newMachine in _newMachines)
            {
                foreach(Machine machine in machines.FindAll(m=>newMachine.Name==m.Name))
                {
                    string msg = string.Format("There is already a machine with the name: {0}\r\nWould you like to replace it?",machine.Name);
                    if(DialogResult.Yes == MessageBox.Show(msg, "Duplicate Machine", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        machine.Replace(newMachine);
                        _newMachines.Remove(newMachine);
                    }
                }
            }
            machines.AddRange(_newMachines);
            XMLSettings.WriteToXmlFile("Config\\Machines.xml", machines);
        }
    }
}
