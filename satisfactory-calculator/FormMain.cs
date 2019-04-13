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

namespace satisfactory_calculator
{
	public partial class FormMain : Form
	{
		public List<Machine> MyMachines;

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
			Console.WriteLine("comboBoxMachine.Text: {0}", comboBoxMachine.Text);
			if (! (101 > numericUpDownQty.Value) &&(numericUpDownQty.Value > 0))
			{
				MessageBox.Show(string.Format("Invalid Qty: {0}", numericUpDownQty.Value));
				return;
			}
			Console.WriteLine("numericUpDownQty.Value contains: {0}", numericUpDownQty.Value);
			if (!comboBoxResource.Items.Contains(comboBoxResource.Text))
			{
				MessageBox.Show(string.Format("Invalid Resource: ' {0} '",comboBoxResource.Text));
				return;
			}
			Console.WriteLine("comboBoxResource.Text contains: {0}", comboBoxResource.Text);
		}

		private void buttonEdit_Click(object sender, EventArgs e)
		{

		}

        #endregion


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
				comboBoxResource.Items.Add(recipe.Name);
			}
			comboBoxResource.SelectedIndex = 0;
		}
	}
}
