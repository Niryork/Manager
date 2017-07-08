namespace 三层架构_UI层
{
    partial class frmStuMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStuMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.个人信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.课程成绩ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PIcp = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PIcp)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(17, 17);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.个人信息ToolStripMenuItem,
            this.课程成绩ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(824, 27);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 个人信息ToolStripMenuItem
            // 
            this.个人信息ToolStripMenuItem.Name = "个人信息ToolStripMenuItem";
            this.个人信息ToolStripMenuItem.Size = new System.Drawing.Size(73, 23);
            this.个人信息ToolStripMenuItem.Text = "个人信息";
            this.个人信息ToolStripMenuItem.Click += new System.EventHandler(this.个人信息ToolStripMenuItem_Click);
            // 
            // 课程成绩ToolStripMenuItem
            // 
            this.课程成绩ToolStripMenuItem.Name = "课程成绩ToolStripMenuItem";
            this.课程成绩ToolStripMenuItem.Size = new System.Drawing.Size(112, 23);
            this.课程成绩ToolStripMenuItem.Text = "选修课程及成绩";
            this.课程成绩ToolStripMenuItem.Click += new System.EventHandler(this.课程成绩ToolStripMenuItem_Click);
            // 
            // PIcp
            // 
            this.PIcp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PIcp.Image = ((System.Drawing.Image)(resources.GetObject("PIcp.Image")));
            this.PIcp.Location = new System.Drawing.Point(0, 242);
            this.PIcp.Name = "PIcp";
            this.PIcp.Size = new System.Drawing.Size(824, 146);
            this.PIcp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PIcp.TabIndex = 16;
            this.PIcp.TabStop = false;
            // 
            // frmStuMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 388);
            this.Controls.Add(this.PIcp);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "frmStuMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生个人信息";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmStuMain_FormClosed);
            this.Load += new System.EventHandler(this.frmStuMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PIcp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 个人信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 课程成绩ToolStripMenuItem;
        private System.Windows.Forms.PictureBox PIcp;
    }
}