using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateTimePickerControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "ddd dd MMM yyyy";
            //dateTimePicker1.CustomFormat = "'Today is:' hh:mm:ss dddd MMMM dd, yyyy";

            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show("The selected value is " + dateTimePicker1.Text);
            MessageBox.Show("The day of the week is " + dateTimePicker1.Value.DayOfWeek.ToString());
            MessageBox.Show("Millisecond is: " + dateTimePicker1.Value.Millisecond.ToString());
        }
    }
}
