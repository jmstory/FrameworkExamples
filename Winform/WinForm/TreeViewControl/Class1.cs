using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomTreeNode
{
    class myTreeNode : TreeNode
    {
        public string FilePath;

        public myTreeNode(string fp)
        {
            FilePath = fp;
            this.Text = fp.Substring(fp.LastIndexOf("\\"));
        }
      
    }
}
