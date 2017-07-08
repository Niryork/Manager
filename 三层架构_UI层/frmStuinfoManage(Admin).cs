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
    public partial class frmStuinfoManage : Form
    {
        BLLStuinfo bll = new BLLStuinfo();
        string msg;
        public frmStuinfoManage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Stuinfo_Load(object sender, EventArgs e)
        {
            BindData();
        }

        /// <summary>
        /// 绑定数据
        /// </summary>
        private void BindData()
        {
            Stuinfo stu = new Stuinfo();
            stu.SNO = txtSNO.Text;
            stu.StuName = txtStuname.Text;
            Stuinfo[] list = bll.GetStuInfoList(stu, out msg);
            //error message
            if (msg != "")
            {
                MessageBox.Show(msg);
            }

            if (list == null)
            {
                list = new Stuinfo[0];
            }
            dgvStuinfo.DataSource = list;

        }

        #region 查询按钮功能
        /// <summary>
        /// 查询按钮功能
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            BindData();
        }

        #endregion

        #region 录入按钮
        /// <summary>
        /// 录入按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmStuEdit stu = new frmStuEdit(null);
            stu.Show();
        }

        #endregion

        #region 删除按键功能
        /// <summary>
        /// 删除按键功能
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDel_Click(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show("是否确认删除", "删除提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == System.Windows.Forms.DialogResult.Yes)
            {
                Stuinfo s = new Stuinfo();
                s.SNO = dgvStuinfo.SelectedRows[0].Cells["SNO"].Value.ToString();
                bool result = bll.Delete(s, out msg);
                MessageBox.Show("删除成功");
                BindData();
            }
        }

        #endregion

        #region 双击修改格事件
        /// <summary>
        /// 双击修改事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvStuinfo_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //赋值
            Stuinfo s = new Stuinfo();
            s.SNO = dgvStuinfo.SelectedRows[0].Cells["SNO"].Value.ToString();
            s.Pwd = dgvStuinfo.SelectedRows[0].Cells["Pwd"].Value.ToString();
            s.StuName = dgvStuinfo.SelectedRows[0].Cells["StuName"].Value.ToString();
            s.Sex = dgvStuinfo.SelectedRows[0].Cells["Sex"].Value.ToString();

            s.Age = dgvStuinfo.SelectedRows[0].Cells["Age"].Value == DBNull.Value ? 0 : Convert.ToInt32(dgvStuinfo.SelectedRows[0].Cells["Age"].Value);
            s.Address = dgvStuinfo.SelectedRows[0].Cells["Address"].Value == DBNull.Value ? "" : dgvStuinfo.SelectedRows[0].Cells["Address"].Value.ToString();

            frmStuEdit stu = new frmStuEdit(s);
            stu.Show();
        }

        #endregion

    }
}
