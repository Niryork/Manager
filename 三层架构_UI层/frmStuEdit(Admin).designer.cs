namespace 三层架构_UI层
{
    partial class frmStuEdit
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
            this.lblSNO = new System.Windows.Forms.Label();
            this.txtSNO = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.lblPwd = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtStuName = new System.Windows.Forms.TextBox();
            this.lblStuName = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.rboMan = new System.Windows.Forms.RadioButton();
            this.rboWoman = new System.Windows.Forms.RadioButton();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnGetStuInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSNO
            // 
            this.lblSNO.AutoSize = true;
            this.lblSNO.Location = new System.Drawing.Point(34, 34);
            this.lblSNO.Name = "lblSNO";
            this.lblSNO.Size = new System.Drawing.Size(33, 13);
            this.lblSNO.TabIndex = 0;
            this.lblSNO.Text = "学号";
            // 
            // txtSNO
            // 
            this.txtSNO.Location = new System.Drawing.Point(101, 31);
            this.txtSNO.Name = "txtSNO";
            this.txtSNO.Size = new System.Drawing.Size(100, 22);
            this.txtSNO.TabIndex = 1;
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(101, 75);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(100, 22);
            this.txtPwd.TabIndex = 3;
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Location = new System.Drawing.Point(34, 78);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(33, 13);
            this.lblPwd.TabIndex = 2;
            this.lblPwd.Text = "密码";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(300, 75);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 22);
            this.txtAge.TabIndex = 5;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(233, 78);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(33, 13);
            this.lblAge.TabIndex = 4;
            this.lblAge.Text = "年龄";
            // 
            // txtStuName
            // 
            this.txtStuName.Location = new System.Drawing.Point(300, 31);
            this.txtStuName.Name = "txtStuName";
            this.txtStuName.Size = new System.Drawing.Size(100, 22);
            this.txtStuName.TabIndex = 7;
            // 
            // lblStuName
            // 
            this.lblStuName.AutoSize = true;
            this.lblStuName.Location = new System.Drawing.Point(233, 34);
            this.lblStuName.Name = "lblStuName";
            this.lblStuName.Size = new System.Drawing.Size(33, 13);
            this.lblStuName.TabIndex = 6;
            this.lblStuName.Text = "姓名";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(34, 120);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(33, 13);
            this.lblSex.TabIndex = 8;
            this.lblSex.Text = "性别";
            // 
            // rboMan
            // 
            this.rboMan.AutoSize = true;
            this.rboMan.Checked = true;
            this.rboMan.Location = new System.Drawing.Point(92, 118);
            this.rboMan.Name = "rboMan";
            this.rboMan.Size = new System.Drawing.Size(38, 17);
            this.rboMan.TabIndex = 9;
            this.rboMan.TabStop = true;
            this.rboMan.Text = "男";
            this.rboMan.UseVisualStyleBackColor = true;
            // 
            // rboWoman
            // 
            this.rboWoman.AutoSize = true;
            this.rboWoman.Location = new System.Drawing.Point(163, 118);
            this.rboWoman.Name = "rboWoman";
            this.rboWoman.Size = new System.Drawing.Size(38, 17);
            this.rboWoman.TabIndex = 10;
            this.rboWoman.TabStop = true;
            this.rboWoman.Text = "女";
            this.rboWoman.UseVisualStyleBackColor = true;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(101, 155);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(299, 70);
            this.txtAddress.TabIndex = 12;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(34, 158);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(33, 13);
            this.lblAddress.TabIndex = 11;
            this.lblAddress.Text = "地址";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(325, 263);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 13;
            this.btnSubmit.Text = "提交";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnGetStuInfo
            // 
            this.btnGetStuInfo.Location = new System.Drawing.Point(142, 263);
            this.btnGetStuInfo.Name = "btnGetStuInfo";
            this.btnGetStuInfo.Size = new System.Drawing.Size(75, 23);
            this.btnGetStuInfo.TabIndex = 14;
            this.btnGetStuInfo.Text = "获取数据";
            this.btnGetStuInfo.UseVisualStyleBackColor = true;
            this.btnGetStuInfo.Click += new System.EventHandler(this.btnGetStuInfo_Click);
            // 
            // frmStuEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 313);
            this.Controls.Add(this.btnGetStuInfo);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.rboWoman);
            this.Controls.Add(this.rboMan);
            this.Controls.Add(this.lblSex);
            this.Controls.Add(this.txtStuName);
            this.Controls.Add(this.lblStuName);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.lblPwd);
            this.Controls.Add(this.txtSNO);
            this.Controls.Add(this.lblSNO);
            this.Name = "frmStuEdit";
            this.Load += new System.EventHandler(this.frmStuEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSNO;
        private System.Windows.Forms.TextBox txtSNO;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtStuName;
        private System.Windows.Forms.Label lblStuName;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.RadioButton rboMan;
        private System.Windows.Forms.RadioButton rboWoman;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnGetStuInfo;
    }
}