using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using StudentManage.Model;
using StudentManage.BLL;

namespace 三层架构_UI层
{
    public partial class frmStuEdit : Form
    {
        Stuinfo s;
        BLLStuinfo bll = new BLLStuinfo();
        string msg;

        public frmStuEdit(Stuinfo stu)
        {
            InitializeComponent();
            s = stu;
        }

        #region 绑定数据
        /// <summary>
        /// 绑定数据
        /// </summary>
        public void BindData()
        {
            if (s != null)
            {
                txtSNO.Text = s.SNO;
                txtStuName.Text = s.StuName;
                txtPwd.Text = s.Pwd;
                txtAge.Text = s.Age.ToString();

                if (s.Sex == "男")
                {
                    rboMan.Checked = true;
                }
                else
                if (s.Sex == "女")
                {
                    rboWoman.Checked = true;
                }

                txtAddress.Text = s.Address;

                this.Text = "学生信息编辑";
                txtSNO.Enabled = false;
            }
            else
            {
                this.Text = "学生信息录入";
            }
        }


        #endregion

        #region 窗体加载事件
        /// <summary>
        /// 绑定数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmStuEdit_Load(object sender, EventArgs e)
        {
            BindData();
        }

        #endregion

        #region 提交按键功能
        /// <summary>
        /// 提交按键功能
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Stuinfo stu = new Stuinfo();

            #region 是否有修改

            stu.SNO = txtSNO.Text;
            stu.Pwd = txtPwd.Text;
            stu.StuName = txtStuName.Text;

            if (Convert.ToInt32(txtAge.Text) <= 35 && Convert.ToInt32(txtAge.Text) > 1)
            {
                stu.Age = Convert.ToInt32(txtAge.Text);
            }
            else
            {
                MessageBox.Show("你输入的年龄不符合规则,请重新输入");
                txtAge.Focus();
                return;
            }

            if (rboMan.Checked == true)
            {
                stu.Sex = "男";
            }
            else
            if (rboWoman.Checked == true)
            {
                stu.Sex = "女";
            }

            stu.Address = txtAddress.Text;

            #endregion

            bool result = bll.IsUpdateSucces(stu, out msg);

            if (msg != "")
            {
                MessageBox.Show(msg);
            }

            if (result)
            {
                MessageBox.Show("编辑成功");
                BindData();
                frmStuinfoManage frm = new frmStuinfoManage();
                frm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("填入的数据有误，请核对过后重新输入");
            }


        }


        #endregion

        #region 获取信息
        /// <summary>
        /// 获取信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGetStuInfo_Click(object sender, EventArgs e)
        {
            if (txtSNO.Text == "")
            {
                MessageBox.Show("请输入学号");
                txtSNO.Focus();
                return;
            }
            Stuinfo stu = new Stuinfo();
            stu.SNO = txtSNO.Text;
            txtSNO.Enabled = false;

            Stuinfo s = bll.GetStuInfo(stu, out msg);
            if (s != null)  //
            {
                txtSNO.Text = s.SNO;
                txtStuName.Text = s.StuName;
                txtPwd.Text = s.Pwd;
                txtAge.Text = s.Age.ToString();

                if (s.Sex == "男")
                {
                    rboMan.Checked = true;
                }
                else
                if (s.Sex == "女")
                {
                    rboWoman.Checked = true;
                }
                txtAddress.Text = s.Address;
            }
            else
            {
                MessageBox.Show("该学号不存在");
                Clear();
            }
        }

        #endregion

        #region 清空
        /// <summary>
        /// 清空
        /// </summary>
        public void Clear()
        {
            txtSNO.Text = "";
            txtStuName.Text = "";
            txtPwd.Text = "";
            txtAge.Text = "";
            txtAddress.Text = "";
            rboMan.Checked = true;
        }

        #endregion

    }
}
