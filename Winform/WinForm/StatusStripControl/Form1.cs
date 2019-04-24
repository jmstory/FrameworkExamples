using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StatusStripControl
{
    public partial class Form1 : Form
    {
        ToolStripStatusLabel middleLabel;
        public Form1()
        {
            InitializeComponent();
            statusStrip1.Items.Add("Left");
            middleLabel = new ToolStripStatusLabel("Middle (Spring)");
            middleLabel.Click += new EventHandler(middleLabel_Click);
            statusStrip1.Items.Add(middleLabel);

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }
        void middleLabel_Click(object sender, EventArgs e)
        {
            // Toggle the value of the Spring property.
            middleLabel.Spring ^= true;

            // Set the Text property according to the
            // value of the Spring property. 
            middleLabel.Text =
                middleLabel.Spring ? "Middle (Spring - True)" : "Middle (Spring - False)";
        }
    }
}
