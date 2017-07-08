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
    public partial class frmStuMain : Form
    {
        Stuinfo ss = new Stuinfo();
        public frmStuMain(string SNO)
        {
            InitializeComponent();
            ss.SNO = SNO;
        }

        private void frmStuMain_Load(object sender, EventArgs e)
        {
        }  
        
        /// <summary>
        /// 加载窗体
        /// </summary>
        /// <param name="frm"></param>
        private void LoadForm(Form frm)
        {
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void frmStuMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void 个人信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStuInfoPrivate frm = new frmStuInfoPrivate(ss.SNO);
            LoadForm(frm);
        }
        private void 课程成绩ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStuSubject frm = new frmStuSubject(ss.SNO);
            LoadForm(frm);
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
