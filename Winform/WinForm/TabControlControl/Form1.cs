using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabControlControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //추가
            //디자이너에선 탭페이지 클릭후 컨트롤버튼 드래그해서 넣으면됨
            tabPage1.Controls.Add(new Button());

            ////
            //string title = "TabPage " + (tabControl1.TabCount + 1).ToString();
            //TabPage myTabPage = new TabPage(title);
            //tabControl1.TabPages.Add(myTabPage);

            ////제거
            //디자이너에선 클릭해서 삭제하면됨
            //tabControl1.TabPages.Remove(tabControl1.SelectedTab);
            //tabControl1.TabPages.Clear();

            ////사용 or 사용불가
            ////디자이너에선 우클릭 속성가서 설정
            //tabPage1.Enabled = false;

            //How to: Disable Tab Pages 이부분 이해 안됨
            

            //사이드 정렬 탭 이것도 이해안됨
            tabControl1.DrawItem += new DrawItemEventHandler(tabControl1_DrawItem);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
           
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_DrawItem(Object sender, System.Windows.Forms.DrawItemEventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((CredentialCheck.Checked == true) && (tabControl1.SelectedTab == tabPage2))
            {
                tabControl1.SelectedTab = tabPage2;
            }
            else if ((CredentialCheck.Checked == false) && (tabControl1.SelectedTab == tabPage2))
            {
                MessageBox.Show("Unable to load tab. You have insufficient access privileges.");
                tabControl1.SelectedTab = tabPage3;
            }
        }

        private void tabControl2_DrawItem(object sender, DrawItemEventArgs e)
        {

            // To display right - aligned tabs
            // 1. Add a TabControl to your form.
            // 2. Set the Alignment property to Right.
            // 3. Set the SizeMode property to Fixed, so that all tabs are the same width.
            // 4. Set the ItemSize property to the preferred fixed size for the tabs. Keep in mind that the ItemSize property behaves as though the tabs were on top, although they are right - aligned.As a result, in order to make the tabs wider, you must change the Height property, and in order to make them taller, you must change the Width property.
            // 4-1. For best result with the code example below, set the Width of the tabs to 25 and the Height to 100.
            // 5. Set the DrawMode property to OwnerDrawFixed.
            // 6. Define a handler for the DrawItem event of TabControl that renders the text from left to right.

            Graphics g = e.Graphics;
            Brush _textBrush;

            // Get the item from the collection.
            TabPage _tabPage = tabControl2.TabPages[e.Index];

            // Get the real bounds for the tab rectangle.
            Rectangle _tabBounds = tabControl2.GetTabRect(e.Index);

            if (e.State == DrawItemState.Selected)
            {

                // Draw a different background color, and don't paint a focus rectangle.
                _textBrush = new SolidBrush(Color.Red);
                g.FillRectangle(Brushes.Gray, e.Bounds);
            }
            else
            {
                _textBrush = new System.Drawing.SolidBrush(e.ForeColor);
                e.DrawBackground();
            }

            // Use our own font.
            Font _tabFont = new Font("Arial", 10.0f, FontStyle.Bold, GraphicsUnit.Pixel);

            // Draw string. Center the text.
            StringFormat _stringFlags = new StringFormat();
            _stringFlags.Alignment = StringAlignment.Center;
            _stringFlags.LineAlignment = StringAlignment.Center;
            g.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));
        }
    }
}
