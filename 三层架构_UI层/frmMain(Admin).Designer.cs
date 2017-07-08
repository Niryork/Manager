namespace 三层架构_UI层
{
    partial class frmAdminMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminMain));
            this.menu1 = new System.Windows.Forms.MenuStrip();
            this.学生信息管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.学生成绩管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.学生课程管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.注销ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu1
            // 
            resources.ApplyResources(this.menu1, "menu1");
            this.menu1.ImageScalingSize = new System.Drawing.Size(17, 17);
            this.menu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.学生信息管理ToolStripMenuItem,
            this.学生成绩管理ToolStripMenuItem,
            this.学生课程管理ToolStripMenuItem,
            this.注销ToolStripMenuItem});
            this.menu1.Name = "menu1";
            // 
            // 学生信息管理ToolStripMenuItem
            // 
            resources.ApplyResources(this.学生信息管理ToolStripMenuItem, "学生信息管理ToolStripMenuItem");
            this.学生信息管理ToolStripMenuItem.Name = "学生信息管理ToolStripMenuItem";
            this.学生信息管理ToolStripMenuItem.Click += new System.EventHandler(this.学生信息管理ToolStripMenuItem_Click);
            // 
            // 学生成绩管理ToolStripMenuItem
            // 
            resources.ApplyResources(this.学生成绩管理ToolStripMenuItem, "学生成绩管理ToolStripMenuItem");
            this.学生成绩管理ToolStripMenuItem.Name = "学生成绩管理ToolStripMenuItem";
            this.学生成绩管理ToolStripMenuItem.Click += new System.EventHandler(this.学生成绩管理ToolStripMenuItem_Click);
            // 
            // 学生课程管理ToolStripMenuItem
            // 
            resources.ApplyResources(this.学生课程管理ToolStripMenuItem, "学生课程管理ToolStripMenuItem");
            this.学生课程管理ToolStripMenuItem.Name = "学生课程管理ToolStripMenuItem";
            this.学生课程管理ToolStripMenuItem.Click += new System.EventHandler(this.学生课程管理ToolStripMenuItem_Click);
            // 
            // 注销ToolStripMenuItem
            // 
            resources.ApplyResources(this.注销ToolStripMenuItem, "注销ToolStripMenuItem");
            this.注销ToolStripMenuItem.Name = "注销ToolStripMenuItem";
            this.注销ToolStripMenuItem.Click += new System.EventHandler(this.注销ToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.menu1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menu1;
            this.Name = "frmMain";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menu1.ResumeLayout(false);
            this.menu1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu1;
        private System.Windows.Forms.ToolStripMenuItem 学生信息管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 学生成绩管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 学生课程管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 注销ToolStripMenuItem;
    }
}