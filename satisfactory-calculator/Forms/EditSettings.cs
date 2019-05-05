using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace satisfactory_calculator.Forms
{
    public partial class EditSettings : Form
    {
        public EditSettings()
        {
            InitializeComponent();

            Init_TabPageMachines();
        }

        private void Init_TabPageMachines()
        {
            treeViewMachines.Nodes.Clear();

            int m = 0; // machine index
            foreach (Machine machine in XMLSettings.AllMachines)
            {
                treeViewMachines.Nodes.Add("Machine: " + machine.Name);
                treeViewMachines.Nodes[m].Nodes.Add(machine.Name);
                treeViewMachines.Nodes[m].Nodes.Add("Ingredients: " + machine.Name);
                
                int i = 0; // ingredient index
                foreach (Material ingredient in machine.Ingredients)
                {
                    treeViewMachines.Nodes[m].Nodes[1].Nodes.Add("Material: " + ingredient.Name);
                    treeViewMachines.Nodes[m].Nodes[1].Nodes[i].Nodes.Add(ingredient.Name);
                    treeViewMachines.Nodes[m].Nodes[1].Nodes[i].Nodes.Add(ingredient.Qty.ToString());

                    i++;
                }
                treeViewMachines.Nodes[m].Nodes.Add(machine.PowerUsage.ToString());

                m++;
            }
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonApply_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
