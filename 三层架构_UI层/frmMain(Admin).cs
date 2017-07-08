using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 三层架构_UI层
{
    public partial class frmAdminMain : Form
    {
        frmLogin frmLog;
        public frmAdminMain(frmLogin frm)
        {
            InitializeComponent();
            frmLog = frm;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 窗体关闭事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// MDI容器
        /// </summary>
        /// <param name="frm"></param>
        private void LoadForm(Form frm)
        {
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void 学生信息管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //加载学生信息框
            frmStuinfoManage stu = new frmStuinfoManage();
            LoadForm(stu);
        }

        private void 学生成绩管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmScoreManage sc = new frmScoreManage();
            LoadForm(sc);

        }

        private void 学生课程管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSubject sub = new frmSubject();
            LoadForm(sub);
        }

        private void 注销ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmLog != null)
            {
                frmLog.Show();
                frmLog.frmMain = this;
            }
                this.Hide();

        }

        /// <summary>
        /// 关闭所有子窗口
        /// </summary>
        public void CloseALLChildForm()
        {
            Form[] formArray = this.MdiChildren;
            foreach (Form item in formArray)
            {
                item.Close();
            }
        }

    }
}
