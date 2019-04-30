using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

            ////노드 추가
            //TreeNode newNode = new TreeNode("Text for new node");
            //treeView1.SelectedNode.Nodes.Add(newNode);

            ////선택 삭제
            //treeView1.Nodes.Remove(treeView1.SelectedNode);

            ////전체 삭제
            //treeView1.Nodes.Clear();

            //
            TreeNode docNode = new TreeNode("Documents");
            docNode.Nodes.Add("phoneList.doc");
            docNode.Nodes.Add("resume.doc");
            treeView1.Nodes.Add(docNode);

            docNode.ContextMenuStrip = contextMenuStrip1;

            treeView1.Nodes.Add(new myTreeNode(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal) + @"TextFiles.txt"));


            //트리뷰 이미지 디스플레이
            //이미지 리스트 추가 
            //트리뷰 속성 이미지리스트 선택
            //이미지리스트 이미지 추가
            treeView1.ImageList = imageList1;
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
            MessageBox.Show(treeNode.Text);

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
    }
}
