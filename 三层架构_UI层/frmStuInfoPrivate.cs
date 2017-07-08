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
    public partial class frmStuInfoPrivate : Form
    {
        Stuinfo ss = new Stuinfo();
        BLLStuinfo bll = new BLLStuinfo();
        string msg;
        public frmStuInfoPrivate(string sno)
        {
            InitializeComponent();
            ss.SNO = sno;
        }

        private void frmStuInfoPrivate_Load(object sender, EventArgs e)
        {
            BindData();
        }

        public void BindData()
        {
            Stuinfo[] list = bll.GetStuInfoList(ss, out msg);
            if (msg != "")
            {
                MessageBox.Show(msg);
            }

            dgvStuPriInfo.DataSource = list;



        }
    }
}
