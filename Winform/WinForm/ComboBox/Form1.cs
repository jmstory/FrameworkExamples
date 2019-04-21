using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // 아래 예제를 적용하기 위해서는 combobox1의 Drawmode를 변경해야 됨.
            comboBox1.DrawMode = DrawMode.OwnerDrawVariable;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            var bFont = new Font("Arial", 8, FontStyle.Bold);
            var lFont = new Font("Arial", 12, FontStyle.Bold);
            var siText = new SizeF();

            if(comboBox1.Items[e.Index].ToString() == "Two")
            {
                siText = e.Graphics.MeasureString(comboBox1.Items[e.Index].ToString(), lFont);
            }
            else
            {
                siText = e.Graphics.MeasureString(comboBox1.Items[e.Index].ToString(), bFont);
            }

            e.ItemHeight = (int)siText.Height;
            e.ItemWidth = (int)siText.Width;
        }

        private void comboBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            var bFont = new Font("Arial", 8, FontStyle.Bold);
            var lFont = new Font("Arial", 12, FontStyle.Bold);
            if(comboBox1.Items[e.Index].ToString() == "Two")
            {
                g.DrawString(comboBox1.Items[e.Index].ToString(), lFont, Brushes.Red, e.Bounds.X, e.Bounds.Y);
            }
            else
            {
                g.DrawString(comboBox1.Items[e.Index].ToString(), bFont, Brushes.Black, e.Bounds.X, e.Bounds.Y);
            }
        }
    }
}
