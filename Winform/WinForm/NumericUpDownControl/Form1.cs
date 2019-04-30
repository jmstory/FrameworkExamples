using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumericUpDownControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            numericUpDown1.Value = 55;
            numericUpDown1.UpButton();

            numericUpDown1.DecimalPlaces = 2;
            numericUpDown1.ThousandsSeparator = true;
            numericUpDown1.Hexadecimal = true;

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value >= 65)
            {
                MessageBox.Show("Age is: " + numericUpDown1.Value.ToString());
            }
            else
            {
                MessageBox.Show("The customer is ineligible for a senior citizen discount.");
            }
        }
    }
}
