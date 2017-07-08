using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using StudentManage.BLL;
using StudentManage.Model;

namespace 三层架构_UI层
{
    public partial class frmLogin : Form
    {
        BLLStuinfo bll = new BLLStuinfo();
        public frmAdminMain frmMain;
        public frmStuMain frmstuMain;
        public frmLogin()
        {
            InitializeComponent();
        }
        string msg;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        public void Login()
        {
            if (!CheckTxTControl())
            {
                return;
            }

            Stuinfo stu = new Stuinfo();
            stu.SNO = txtAccount.Text;
            stu.Pwd = txtPwd.Text;
            //管理员登陆
            if (rboadminlogin.Checked)
            {
                IsLogin(stu, out msg);
            }
            //学生登陆
            if (rboStuLogin.Checked)
            {
                IsLogin(stu, out msg);
            }

        }
        /// <summary>
        /// 登录管理
        /// </summary>
        /// <param name="stu"></param>
        /// <param name="msg"></param>
        public void IsLogin(Stuinfo stu, out string msg)
        {
            bool result = bll.IsLoginSuccess(stu, out msg);

            if (msg != "")
            {
                MessageBox.Show("msg");
            }

            if (result)
            {
                //管理员登录
                if (rboadminlogin.Checked)
                {
                    if (frmMain == null)
                    {
                        frmMain = new frmAdminMain(this);
                    }
                    frmMain.CloseALLChildForm();
                    frmMain.Show();
                }
                //学生登录
                if (rboStuLogin.Checked)
                {
                    if (stu.SNO != "admin")
                    {
                        frmStuMain frm = new frmStuMain(stu.SNO);
                        frm.Show();
                    }
                    else
                    {
                        MessageBox.Show("请输入学生账号！");
                        txtAccount.Text = "";
                        txtPwd.Text = "";
                        return;
                    }
                }
                this.Hide();
            }
            else
            {
                MessageBox.Show("您输入的账号或密码错误，请重新输入");
            }

        }
        /// <summary>
        /// 检查输入是否为空
        /// </summary>
        /// <returns></returns>
        public bool CheckTxTControl()
        {
            if (txtAccount.Text == "")
            {
                MessageBox.Show("请输入账号");
                txtAccount.Focus();
                return false;
            }
            if (txtPwd.Text == "")
            {
                MessageBox.Show("请输入密码");
                txtPwd.Focus();
                return false;
            }
            return true;
        }



        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtAccount.Focus();
            rboadminlogin.Checked = true;
        }

        #region 回车键登登录
        private void txtAccount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }

        private void txtPwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }

        private void btnLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }

        }

        #endregion

    }
}
