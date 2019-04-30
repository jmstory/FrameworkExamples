using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToolTipComponentControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            toolTip1.SetToolTip(button1, "Save chagnes");

            //To remove a ToolTip programmatically
            //toolTip1.SetToolTip(button1, null);

            //To set the delay
            toolTip1.InitialDelay = 500;
            toolTip1.ReshowDelay = 100;
            toolTip1.AutoPopDelay = 5000;
        }
    }
}
