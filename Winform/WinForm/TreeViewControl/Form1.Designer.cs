namespace TreeViewControl
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("노드3");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("노드6");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("노드1", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("노드4");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("노드5");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("노드2", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("노드0", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("노드9");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("노드10");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("노드3", new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("노드11");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("노드12");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("노드4", new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode12});
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("노드0", new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode13});
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("노드5");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("노드6");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("노드1", new System.Windows.Forms.TreeNode[] {
            treeNode15,
            treeNode16});
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("노드13");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("노드14");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("노드15");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("노드7", new System.Windows.Forms.TreeNode[] {
            treeNode18,
            treeNode19,
            treeNode20});
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("노드8");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("노드2", new System.Windows.Forms.TreeNode[] {
            treeNode21,
            treeNode22});
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("노드2");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("노드3");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("노드0", new System.Windows.Forms.TreeNode[] {
            treeNode24,
            treeNode25});
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("노드4");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("노드5");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("노드1", new System.Windows.Forms.TreeNode[] {
            treeNode27,
            treeNode28});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.menuTreeView = new System.Windows.Forms.TreeView();
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.treeView3 = new System.Windows.Forms.TreeView();
            this.treeView4 = new System.Windows.Forms.TreeView();
            this.buttonIterate = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.treeView5 = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(23, 71);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(162, 107);
            this.treeView1.TabIndex = 0;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Magenta;
            this.imageList1.Images.SetKeyName(0, "window.bmp");
            this.imageList1.Images.SetKeyName(1, "XPfolder_closed.bmp");
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.renameToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(118, 70);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // renameToolStripMenuItem
            // 
            this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
            this.renameToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.renameToolStripMenuItem.Text = "Rename";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(23, 184);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(44, 23);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(73, 184);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(60, 23);
            this.buttonRemove.TabIndex = 2;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(139, 184);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(50, 23);
            this.buttonClear.TabIndex = 3;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // menuTreeView
            // 
            this.menuTreeView.Location = new System.Drawing.Point(371, 71);
            this.menuTreeView.Name = "menuTreeView";
            this.menuTreeView.Size = new System.Drawing.Size(161, 107);
            this.menuTreeView.TabIndex = 4;
            // 
            // treeView2
            // 
            this.treeView2.Location = new System.Drawing.Point(719, 71);
            this.treeView2.Name = "treeView2";
            this.treeView2.Size = new System.Drawing.Size(169, 107);
            this.treeView2.TabIndex = 5;
            this.treeView2.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView2_AfterSelect);
            // 
            // treeView3
            // 
            this.treeView3.Location = new System.Drawing.Point(19, 272);
            this.treeView3.Name = "treeView3";
            treeNode1.Name = "노드3";
            treeNode1.Text = "노드3";
            treeNode2.Name = "노드6";
            treeNode2.Text = "노드6";
            treeNode3.Name = "노드1";
            treeNode3.Text = "노드1";
            treeNode4.Name = "노드4";
            treeNode4.Text = "노드4";
            treeNode5.Name = "노드5";
            treeNode5.Text = "노드5";
            treeNode6.Name = "노드2";
            treeNode6.Text = "노드2";
            treeNode7.Name = "노드0";
            treeNode7.Text = "노드0";
            this.treeView3.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode7});
            this.treeView3.Size = new System.Drawing.Size(166, 129);
            this.treeView3.TabIndex = 6;
            this.treeView3.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView3_AfterSelect);
            // 
            // treeView4
            // 
            this.treeView4.Location = new System.Drawing.Point(313, 272);
            this.treeView4.Name = "treeView4";
            treeNode8.Name = "노드9";
            treeNode8.Text = "노드9";
            treeNode9.Name = "노드10";
            treeNode9.Text = "노드10";
            treeNode10.Name = "노드3";
            treeNode10.Text = "노드3";
            treeNode11.Name = "노드11";
            treeNode11.Text = "노드11";
            treeNode12.Name = "노드12";
            treeNode12.Text = "노드12";
            treeNode13.Name = "노드4";
            treeNode13.Text = "노드4";
            treeNode14.Name = "노드0";
            treeNode14.Text = "노드0";
            treeNode15.Name = "노드5";
            treeNode15.Text = "노드5";
            treeNode16.Name = "노드6";
            treeNode16.Text = "노드6";
            treeNode17.Name = "노드1";
            treeNode17.Text = "노드1";
            treeNode18.Name = "노드13";
            treeNode18.Text = "노드13";
            treeNode19.Name = "노드14";
            treeNode19.Text = "노드14";
            treeNode20.Name = "노드15";
            treeNode20.Text = "노드15";
            treeNode21.Name = "노드7";
            treeNode21.Text = "노드7";
            treeNode22.Name = "노드8";
            treeNode22.Text = "노드8";
            treeNode23.Name = "노드2";
            treeNode23.Text = "노드2";
            this.treeView4.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode14,
            treeNode17,
            treeNode23});
            this.treeView4.Size = new System.Drawing.Size(161, 130);
            this.treeView4.TabIndex = 7;
            // 
            // buttonIterate
            // 
            this.buttonIterate.Location = new System.Drawing.Point(399, 408);
            this.buttonIterate.Name = "buttonIterate";
            this.buttonIterate.Size = new System.Drawing.Size(75, 23);
            this.buttonIterate.TabIndex = 8;
            this.buttonIterate.Text = "Iterate";
            this.buttonIterate.UseVisualStyleBackColor = true;
            this.buttonIterate.Click += new System.EventHandler(this.buttonIterate_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(480, 272);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(137, 130);
            this.textBox1.TabIndex = 9;
            // 
            // treeView5
            // 
            this.treeView5.Location = new System.Drawing.Point(719, 271);
            this.treeView5.Name = "treeView5";
            treeNode24.Name = "노드2";
            treeNode24.Text = "노드2";
            treeNode25.Name = "노드3";
            treeNode25.Text = "노드3";
            treeNode26.Name = "노드0";
            treeNode26.Text = "노드0";
            treeNode27.Name = "노드4";
            treeNode27.Text = "노드4";
            treeNode28.Name = "노드5";
            treeNode28.Text = "노드5";
            treeNode29.Name = "노드1";
            treeNode29.Text = "노드1";
            this.treeView5.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode26,
            treeNode29});
            this.treeView5.Size = new System.Drawing.Size(157, 130);
            this.treeView5.TabIndex = 10;
            this.treeView5.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView5_AfterSelect);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "Add and Remove Nodes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(371, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "Attach a ShortCut Menu to a TreeView Node";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(717, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 12);
            this.label3.TabIndex = 13;
            this.label3.Text = "Add Custom Information to a TreeView";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(266, 12);
            this.label4.TabIndex = 14;
            this.label4.Text = "Determine Which TreeView Node Was Clicked";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(349, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 12);
            this.label5.TabIndex = 15;
            this.label5.Text = "Iterate Through All Nodes";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(719, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 12);
            this.label6.TabIndex = 16;
            this.label6.Text = "Set Icons";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.treeView5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonIterate);
            this.Controls.Add(this.treeView4);
            this.Controls.Add(this.treeView3);
            this.Controls.Add(this.treeView2);
            this.Controls.Add(this.menuTreeView);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.TreeView menuTreeView;
        private System.Windows.Forms.TreeView treeView2;
        private System.Windows.Forms.TreeView treeView3;
        private System.Windows.Forms.TreeView treeView4;
        private System.Windows.Forms.Button buttonIterate;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TreeView treeView5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

