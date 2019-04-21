using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                checkBox1.Text = "Checked";
            }
            else
            {
                checkBox1.Text = "Unchecked";
            }

            //////////////////////////////////////////////
            switch (checkBox1.CheckState)
            {
                case CheckState.Checked:
                    // Code for checked state.  
                    break;
                case CheckState.Unchecked:
                    // Code for unchecked state.  
                    break;
                case CheckState.Indeterminate:
                    // Code for indeterminate state.  
                    break;
            }
           

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox2.CheckState == CheckState.Checked)
            {
                this.AllowDrop = false;
            }
            
        }
    }
}
