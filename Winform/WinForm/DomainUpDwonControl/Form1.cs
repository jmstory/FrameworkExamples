using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DomainUpDwonControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            domainUpDown1.Items.Add("noodles");
            //domainUpDown1.Items.Insert(2, "rice");

            //To remove an item
            //domainUpDown1.Items.Remove("noodles");
            //domainUpDown1.Items.RemoveAt(0);
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }
    }
}
