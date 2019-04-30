using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomTreeNode;

namespace TreeViewControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            TreeNode docNode = new TreeNode("Documents");
            docNode.Nodes.Add("phoneList.doc");
            docNode.Nodes.Add("resume.doc");
            menuTreeView.Nodes.Add(docNode);

            docNode.ContextMenuStrip = contextMenuStrip1;

            //treeView2.Nodes.Add(new myTreeNode(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal) + @"\TextFiles.txt"));
            string[] files = Directory.GetFiles(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal));
            foreach(var f in files)
            {
                treeView2.Nodes.Add(new myTreeNode(f));
            }


            //트리뷰 이미지 디스플레이
            //이미지 리스트 추가 
            //트리뷰 속성 이미지리스트 선택
            //이미지리스트 이미지 추가
            treeView5.ImageList = imageList1;

            // treeView1.SelectedNode가 널이기 때문에 아래 코드는 동작안함
            //treeView1.SelectedNode.ImageIndex = 0;
            //treeView1.SelectedNode.SelectedImageIndex = 1;

        }

        protected void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //myTreeNode myNode = (myTreeNode)e.Node;

            MessageBox.Show(e.Node.Text);
        }

        private void PrintRecursive(TreeNode treeNode)
        {
            //프린트 노드
            System.Diagnostics.Debug.WriteLine(treeNode.Text);
            //MessageBox.Show(treeNode.Text);
            textBox1.Text += treeNode.Text + Environment.NewLine;

            foreach (TreeNode tn in treeNode.Nodes)
            {
                PrintRecursive(tn);
            }
        }

        private void CallRecursive(TreeView treeView)
        {            
            TreeNodeCollection nodes = treeView.Nodes;
            foreach (TreeNode n in nodes)
            {
                PrintRecursive(n);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            TreeNode newNode = new TreeNode("Text for new node");
            if (treeView1.SelectedNode != null)
            {
                ////노드 추가
                
                treeView1.SelectedNode.Nodes.Add(newNode);
            }
            else
            {
                treeView1.Nodes.Add(newNode);
            }

        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null)
            {
                ////선택 삭제
                treeView1.Nodes.Remove(treeView1.SelectedNode);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ////전체 삭제
            treeView1.Nodes.Clear();
        }

        private void treeView2_AfterSelect(object sender, TreeViewEventArgs e)
        {
            myTreeNode myNode = (myTreeNode)e.Node;
            // 선택된 노드의 FilePath를 쓰기위해 캐스팅 해 줘야됨.
            // e.Node는 TreeNode로 선언되어 있지만 실제 노드 인스턴스는 myTreeNode인스턴스 타입.
            MessageBox.Show(myNode.FilePath);
        }

        private void treeView3_AfterSelect(object sender, TreeViewEventArgs e)
        {
            MessageBox.Show(e.Node.Text);
        }

        private void buttonIterate_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            CallRecursive(treeView4);
        }

        private void treeView5_AfterSelect(object sender, TreeViewEventArgs e)
        {
            treeView5.SelectedNode.ImageIndex = 0;
            treeView5.SelectedNode.SelectedImageIndex = 1;
        }
    }
}
