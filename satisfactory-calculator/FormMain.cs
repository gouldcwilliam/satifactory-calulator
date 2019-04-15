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
		public List<Machine> MyMachines = new List<Machine>();
		class totals
		{
			public string Name;
			public int Output;
			public int Input;
			public totals(string name, int output, int input)
			{ Name = name; Output = output; Input = input; }
		}
		List<totals> globalTotals;
		public FormMain()
		{
			InitializeComponent();

			pictureBoxSatisfactoryIcon.BringToFront();
			pictureBoxSatisfactoryIcon.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBoxSatisfactoryIcon.Image = Image.FromFile("../../Images/Satisfactory-original.png");

			foreach (Machine machine in BuilderClass.Machines.GetMachines())
			{
				comboBoxMachine.Items.Add(machine.Name);
			}
			comboBoxMachine.SelectedIndex = 0;

		}




        #region TOP PANELS

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);


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
		#endregion


		#region BUTTONS
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


			Machine machine = BuilderClass.Machines.GetMachines().Find(x => x.Name == comboBoxMachine.Text);
			machine.CurrentRecipe = machine.AvailableRecipes.Find(x => x.Name == comboBoxResource.Text);
			machine.Total = (int)numericUpDownQty.Value;
			MyMachines.Add(machine);
			dataGridViewMachines.Rows.Add(dataGridViewMachines.Rows.Count,machine.Name, machine.Total, machine.CurrentRecipe.Name, machine.CurrentRecipe.OutputMaterial.Qty * machine.Total);

			Functions.myLog("MyMachines.Add(machine):\n - ", machine);
			Functions.myLog("dataGridViewMachines.Rows.Add(machine):\n - {0}", machine);

		}

		private void buttonEdit_Click(object sender, EventArgs e)
		{
			return;
		}

		#endregion


		private void dataGridViewGlobalTotals_AddMachineTotals(Machine machine)
		{
			//foreach (Material material in machine.CurrentRecipe.InputMaterials)
			//{
			//	if (!(globalTotals.Count>0)) { return; }
			//	material.Qty = material.Qty * machine.Total;
			//	bool found = false;
			//	foreach (totals totals in globalTotals)
			//	{
			//		if(totals.Name==material.Name)
			//		{
			//			globalTotals.Remove(totals);
			//			globalTotals.Add(new totals(totals.Name,totals.Input+(material.Qty*machine.Total) )
			//			found = true;
			//		}
			//	}
			//	if(!found)
			//	{
			//		machine.CurrentRecipe.InputMaterials.Add(new)
			//	}
			}
			
		}




		private void test()
        {
			Functions.WriteToXmlFile<List<Machine>>("Machines.xml", BuilderClass.Machines.GetMachines());
			foreach (Machine machine in BuilderClass.Machines.GetMachines())
			{
				Console.WriteLine("machine: {0}", machine.Name);
				foreach (Recipe recipe in machine.AvailableRecipes)
				{
					Console.WriteLine("\trecipe:  {0}", recipe.Name);
					Console.WriteLine("\t\toutput material: {0}, {1}", recipe.OutputMaterial.Name, recipe.OutputMaterial.Qty);
					foreach (Material material in recipe.InputMaterials)
					{
						Console.WriteLine("\t\tinput material: {0} {1}", material.Name, material.Qty);
					}

				}
			}
        }

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

		private void dataGridViewMachines_SelectionChanged(object sender, EventArgs e)
		{
			if (!(dataGridViewMachines.SelectedRows.Count > 0)) { return; }

			int index = dataGridViewMachines.SelectedRows[0].Index;
			dataGridViewInputs.Rows.Clear();
			foreach (Material material in MyMachines[index].CurrentRecipe.InputMaterials)
			{
				dataGridViewInputs.Rows.Add(material.Name, material.Qty * MyMachines[index].Total);
				Functions.myLog(string.Format("dataGridViewInputs.Rows.Add(material.Name, material.Qty): - {0}\n - {1}", material.Name, material.Qty));
			}
			Functions.myLog(string.Format("dataGridViewMachines.SelectedRows[0].Index:\n - {0}", index.ToString()));
			Functions.myLog("MyMachines[index]", MyMachines[index]);

			dataGridViewInputs.Refresh();
		}
	}
}
