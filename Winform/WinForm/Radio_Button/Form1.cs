using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Radio_Button
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            if (rb == null)
            {
                MessageBox.Show("Sender is not a RadioButton");
                return;
            }

            if (rb.Checked)
            {
                selectedrb = rb;
            }
        }       

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {            
            MessageBox.Show(selectedrb.Text);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
