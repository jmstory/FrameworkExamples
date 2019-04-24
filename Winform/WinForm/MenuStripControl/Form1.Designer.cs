using System.Windows.Forms;

namespace MenuStripControl
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItemToolStripMenuItem,
            this.openToolStripMenuItemToolStripMenuItem,
            this.toolStripSeparator1ToolStripMenuItem,
            this.saveToolStripMenuItemToolStripMenuItem,
            this.exitToolStripMenuItemToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(138, 20);
            this.fileToolStripMenuItem.Text = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // newToolStripMenuItemToolStripMenuItem
            // 
            this.newToolStripMenuItemToolStripMenuItem.Name = "newToolStripMenuItemToolStripMenuItem";
            this.newToolStripMenuItemToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.newToolStripMenuItemToolStripMenuItem.Text = "newToolStripMenuItem";
            this.newToolStripMenuItemToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItemToolStripMenuItem_Click);
            // 
            // openToolStripMenuItemToolStripMenuItem
            // 
            this.openToolStripMenuItemToolStripMenuItem.Name = "openToolStripMenuItemToolStripMenuItem";
            this.openToolStripMenuItemToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.openToolStripMenuItemToolStripMenuItem.Text = "openToolStripMenuItem";
            this.openToolStripMenuItemToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItemToolStripMenuItem_Click);
            // 
            // toolStripSeparator1ToolStripMenuItem
            // 
            this.toolStripSeparator1ToolStripMenuItem.Name = "toolStripSeparator1ToolStripMenuItem";
            this.toolStripSeparator1ToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.toolStripSeparator1ToolStripMenuItem.Text = "toolStripSeparator1";
            // 
            // saveToolStripMenuItemToolStripMenuItem
            // 
            this.saveToolStripMenuItemToolStripMenuItem.Name = "saveToolStripMenuItemToolStripMenuItem";
            this.saveToolStripMenuItemToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.saveToolStripMenuItemToolStripMenuItem.Text = "saveToolStripMenuItem";
            // 
            // exitToolStripMenuItemToolStripMenuItem
            // 
            this.exitToolStripMenuItemToolStripMenuItem.Name = "exitToolStripMenuItemToolStripMenuItem";
            this.exitToolStripMenuItemToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.exitToolStripMenuItemToolStripMenuItem.Text = "exitToolStripMenuItem";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(127, 20);
            this.toolStripMenuItem2.Text = "toolStripMenuItem2";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 48);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked_1);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 24);
            this.menuStrip2.TabIndex = 4;
            this.menuStrip2.Text = "menuStrip2";
            this.menuStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip2_ItemClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItemToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItemToolStripMenuItem;
        private ToolStripMenuItem toolStripSeparator1ToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItemToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItemToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripMenuItem toolStripMenuItem2;
        private MenuStrip menuStrip2;
        //private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        //private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        //private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        //private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

