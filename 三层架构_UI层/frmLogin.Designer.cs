namespace 三层架构_UI层
{
    partial class frmLogin
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblAccount = new System.Windows.Forms.Label();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.lblPwd = new System.Windows.Forms.Label();
            this.rboadminlogin = new System.Windows.Forms.RadioButton();
            this.rboStuLogin = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(131, 168);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(69, 24);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "登录";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            this.btnLogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnLogin_KeyDown);
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Location = new System.Drawing.Point(33, 37);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(29, 12);
            this.lblAccount.TabIndex = 1;
            this.lblAccount.Text = "账号";
            // 
            // txtAccount
            // 
            this.txtAccount.Location = new System.Drawing.Point(88, 34);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(113, 21);
            this.txtAccount.TabIndex = 2;
            this.txtAccount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAccount_KeyDown);
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(88, 76);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(113, 21);
            this.txtPwd.TabIndex = 4;
            this.txtPwd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPwd_KeyDown);
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Location = new System.Drawing.Point(33, 78);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(29, 12);
            this.lblPwd.TabIndex = 3;
            this.lblPwd.Text = "密码";
            // 
            // rboadminlogin
            // 
            this.rboadminlogin.AutoSize = true;
            this.rboadminlogin.Location = new System.Drawing.Point(35, 126);
            this.rboadminlogin.Name = "rboadminlogin";
            this.rboadminlogin.Size = new System.Drawing.Size(83, 16);
            this.rboadminlogin.TabIndex = 5;
            this.rboadminlogin.TabStop = true;
            this.rboadminlogin.Text = "管理员登陆";
            this.rboadminlogin.UseVisualStyleBackColor = true;
            // 
            // rboStuLogin
            // 
            this.rboStuLogin.AutoSize = true;
            this.rboStuLogin.Location = new System.Drawing.Point(157, 126);
            this.rboStuLogin.Name = "rboStuLogin";
            this.rboStuLogin.Size = new System.Drawing.Size(47, 16);
            this.rboStuLogin.TabIndex = 6;
            this.rboStuLogin.TabStop = true;
            this.rboStuLogin.Text = "学生";
            this.rboStuLogin.UseVisualStyleBackColor = true;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 207);
            this.Controls.Add(this.rboStuLogin);
            this.Controls.Add(this.rboadminlogin);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.lblPwd);
            this.Controls.Add(this.txtAccount);
            this.Controls.Add(this.lblAccount);
            this.Controls.Add(this.btnLogin);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "管理员登陆";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.RadioButton rboadminlogin;
        private System.Windows.Forms.RadioButton rboStuLogin;
    }
}