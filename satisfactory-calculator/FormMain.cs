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
		Building.Machines Machines;
		Materials.Items Items;

		public FormMain()
		{
			InitializeComponent();
			Machines = new Building.Machines();
			Items = new Materials.Items();

			foreach (Machine machine in Machines.List) { comboBoxMachine.Items.Add(machine.Name); }
			comboBoxMachine.SelectedIndex = 0;
			for (int i = 1; i < 21; i++) { comboBoxQty.Items.Add(i); }
			comboBoxQty.SelectedIndex = 0;
			pictureBoxSatisfactoryIcon.BringToFront();
			pictureBoxSatisfactoryIcon.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBoxSatisfactoryIcon.Image = Image.FromFile("../../Images/Satisfactory-original.png");

            
		}


		public const int WM_NCLBUTTONDOWN = 0xA1;
		public const int HTCAPTION = 0x2;
		[DllImport("User32.dll")]
		public static extern bool ReleaseCapture();
		[DllImport("User32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);




        #region TOP PANELS
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
		}

		private void buttonEdit_Click(object sender, EventArgs e)
		{

		}

        #endregion


        private void FormMain_Shown(object sender, EventArgs e)
		{
            Materials.Ores._listProperties();
        }
	}
}
