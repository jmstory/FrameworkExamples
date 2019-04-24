using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MenuStripControl;

namespace MenuStripControl
{
    public partial class Form1 : Form
    {
        private ToolStripMenuItem mainToolStripMenuItem = new ToolStripMenuItem();
        private ToolStripMenuItem toolStripMenuItem1 = new ToolStripMenuItem();
        private ToolStripRadioButtonMenuItem toolStripRadioButtonMenuItem1 =
            new ToolStripRadioButtonMenuItem();
        private ToolStripRadioButtonMenuItem toolStripRadioButtonMenuItem2 =
            new ToolStripRadioButtonMenuItem();
        private ToolStripRadioButtonMenuItem toolStripRadioButtonMenuItem3 =
            new ToolStripRadioButtonMenuItem();
        private ToolStripRadioButtonMenuItem toolStripRadioButtonMenuItem4 =
            new ToolStripRadioButtonMenuItem();
        private ToolStripRadioButtonMenuItem toolStripRadioButtonMenuItem5 =
            new ToolStripRadioButtonMenuItem();
        private ToolStripRadioButtonMenuItem toolStripRadioButtonMenuItem6 =
            new ToolStripRadioButtonMenuItem();
        public Form1()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {            
            openToolStripMenuItemToolStripMenuItem.Click += new System.EventHandler(openToolStripMenuItem_Click);

            //To disable a menu item programmatically
            //menuStrip1.Enabled = false;

            //To disable a menu item at design time
            //With the menu item selected on the form, set the Enabled property to false.

            //

            mainToolStripMenuItem.Text = "main";
            toolStripRadioButtonMenuItem1.Text = "option 1";
            toolStripRadioButtonMenuItem2.Text = "option 2";
            toolStripRadioButtonMenuItem3.Text = "option 2-1";
            toolStripRadioButtonMenuItem4.Text = "option 2-2";
            toolStripRadioButtonMenuItem5.Text = "option 3-1";
            toolStripRadioButtonMenuItem6.Text = "option 3-2";
            toolStripMenuItem1.Text = "toggle";
            toolStripMenuItem1.CheckOnClick = true;

            mainToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
            toolStripRadioButtonMenuItem1, toolStripRadioButtonMenuItem2,
            toolStripMenuItem1});
            toolStripRadioButtonMenuItem2.DropDownItems.AddRange(
                new ToolStripItem[] {toolStripRadioButtonMenuItem3,
            toolStripRadioButtonMenuItem4});
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] {
            toolStripRadioButtonMenuItem5, toolStripRadioButtonMenuItem6});

            menuStrip1.Items.AddRange(new ToolStripItem[] { mainToolStripMenuItem });
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Text = "ToolStripRadioButtonMenuItem demo";


            //How to: Hide ToolStripMenuItems
            toolStripMenuItem2.Visible = false;

            //How to: Configure MenuStrip Check Margins and Image Margins
            this.Width = 500;
            this.Text = "ToolStripContextMenuStrip: Image and Check Margins";

            ToolStripMenuItem bothMargins = new ToolStripMenuItem("BothMargins");
            ToolStripMenuItem imageMarginOnly = new ToolStripMenuItem("ImageMargin");
            ToolStripMenuItem checkMarginOnly = new ToolStripMenuItem("CheckMargin");
            ToolStripMenuItem noMargins = new ToolStripMenuItem("NoMargins");

            bothMargins.DropDown = CreateCheckImageContextMenuStrip();
            ((ContextMenuStrip)bothMargins.DropDown).ShowImageMargin = true;
            ((ContextMenuStrip)bothMargins.DropDown).ShowCheckMargin = true;

            imageMarginOnly.DropDown = CreateCheckImageContextMenuStrip();
            ((ContextMenuStrip)imageMarginOnly.DropDown).ShowImageMargin = true;
            ((ContextMenuStrip)imageMarginOnly.DropDown).ShowCheckMargin = false;

            checkMarginOnly.DropDown = CreateCheckImageContextMenuStrip();
            ((ContextMenuStrip)checkMarginOnly.DropDown).ShowImageMargin = false;
            ((ContextMenuStrip)checkMarginOnly.DropDown).ShowCheckMargin = true;

            noMargins.DropDown = CreateCheckImageContextMenuStrip();
            ((ContextMenuStrip)noMargins.DropDown).ShowImageMargin = false;
            ((ContextMenuStrip)noMargins.DropDown).ShowCheckMargin = false;
                       
            menuStrip2.Items.Add(bothMargins);
            menuStrip2.Items.Add(imageMarginOnly);
            menuStrip2.Items.Add(checkMarginOnly);
            menuStrip2.Items.Add(noMargins);

            menuStrip2.Dock = DockStyle.Top;

        }



        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 newMDIChild = new Form2();          
            newMDIChild.MdiParent = this;          
            newMDIChild.Show();
        }

        private void newToolStripMenuItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 newMDIChild = new Form2();            
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void toolStripMenuItem1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 newMDIChild = new Form2();            
            newMDIChild.MdiParent = this;            
            newMDIChild.Show();
        }

  

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        internal Bitmap CreateSampleBitmap()
        {
            // The Bitmap is a smiley face.
            Bitmap sampleBitmap = new Bitmap(32, 32);
            Graphics g = Graphics.FromImage(sampleBitmap);

            using (Pen p = new Pen(ProfessionalColors.ButtonPressedBorder))
            {
                // Set the Pen width.
                p.Width = 4;

                // Set up the mouth geometry.
                Point[] curvePoints = new Point[]{
                new Point(4,14),
                new Point(16,24),
                new Point(28,14)};

                // Draw the mouth.
                g.DrawCurve(p, curvePoints);

                // Draw the eyes.
                g.DrawEllipse(p, new Rectangle(new Point(7, 4), new Size(3, 3)));
                g.DrawEllipse(p, new Rectangle(new Point(22, 4), new Size(3, 3)));
            }

            return sampleBitmap;
        }
        internal ContextMenuStrip CreateCheckImageContextMenuStrip()
        {
            // Create a new ContextMenuStrip control.
            ContextMenuStrip checkImageContextMenuStrip = new ContextMenuStrip();

            // Create a ToolStripMenuItem with a
            // check margin and an image margin.
            ToolStripMenuItem yesCheckYesImage =
                new ToolStripMenuItem("Check, Image");
            yesCheckYesImage.Checked = true;
            yesCheckYesImage.Image = CreateSampleBitmap();

            // Create a ToolStripMenuItem with no
            // check margin and with an image margin.
            ToolStripMenuItem noCheckYesImage =
                new ToolStripMenuItem("No Check, Image");
            noCheckYesImage.Checked = false;
            noCheckYesImage.Image = CreateSampleBitmap();

            // Create a ToolStripMenuItem with a
            // check margin and without an image margin.
            ToolStripMenuItem yesCheckNoImage =
                new ToolStripMenuItem("Check, No Image");
            yesCheckNoImage.Checked = true;

            // Create a ToolStripMenuItem with no
            // check margin and no image margin.
            ToolStripMenuItem noCheckNoImage =
                new ToolStripMenuItem("No Check, No Image");
            noCheckNoImage.Checked = false;

            // Add the ToolStripMenuItems to the ContextMenuStrip control.
            checkImageContextMenuStrip.Items.Add(yesCheckYesImage);
            checkImageContextMenuStrip.Items.Add(noCheckYesImage);
            checkImageContextMenuStrip.Items.Add(yesCheckNoImage);
            checkImageContextMenuStrip.Items.Add(noCheckNoImage);

            return checkImageContextMenuStrip;
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

      
    }
}
