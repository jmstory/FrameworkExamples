using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextBoxControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox4.Text = "She said, \"You deserve a treat!\"";
            textBox5.Text = "She said, " + '\u0022' + "You deserve a treat!" + '\u0022';
            const string quote = "\"";
            textBox6.Text = "She said, " + quote + "You deserve a treat!" + quote;
        }

        //여기로 안들어오는데?
        //@전민기: 이벤트 연결이 안되어 있었음.
        private void textBox1_Enter(object sender, System.EventArgs e)
        {
            //@전민기: 아래의 두 줄을 주석 처리하고 프로그램 실행 후 탭키로 포커스를 왔다갔다 해볼 것
            textBox1.SelectionStart = 0;
            textBox1.SelectionLength = 0;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
