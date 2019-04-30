using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotiftIconControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            notifyIcon1.Icon =
               new System.Drawing.Icon(System.Environment.GetFolderPath
               (System.Environment.SpecialFolder.Personal)
               + @"\Icon.ico");
                        notifyIcon1.Visible = true;
                        notifyIcon1.Text = "Antivirus program";
        }
    }
}
