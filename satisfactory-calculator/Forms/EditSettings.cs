﻿using System;
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

        public Machine Machine { get { return _machine; } }
        Machine _machine;
        public EditSettings()
        {
            InitializeComponent();
            _machine = new Machine();
        }




        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _machine.Name = textBoxName.Text.Trim();
                _machine.PowerUsage = Convert.ToDouble(textBox2.Text.Trim());
                foreach (string line in textBoxIngredients.Lines)
                {
                    if (line == string.Empty) continue;
                    string[] ingreds = line.Split(',');
                    _machine.Ingredients.Add(new Material(ingreds[1].Trim(), Convert.ToDouble(ingreds[0].Trim())));
                }
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something happened : " + ex.Message);
                this.DialogResult = DialogResult.No;
            }
        }

        private void ButtonFormat_Click(object sender, EventArgs e)
        {
            string formatted = string.Empty;
            foreach (string line in textBoxIngredients.Lines)
            {
                if (line == string.Empty) continue;
                string newline = line.Replace(" × ", " , ");
                newline = newline.Substring(0, newline.IndexOf(".png"));
                if (formatted == string.Empty) formatted = newline;
                else formatted += "\r\n" + newline;
            }
            if (formatted != string.Empty) textBoxIngredients.Text = formatted;
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
