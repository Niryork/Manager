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
    public partial class frmStuSubject : Form
    {
        string msg;
        frmStuMain frmstu;
        StuScore sc = new StuScore();
        BLLScore bll = new BLLScore();

        public frmStuSubject(string sno)
        {
            InitializeComponent();
            sc.SNO = sno;
        }

        private void frmStuSubject_Load(object sender, EventArgs e)
        {
            BindData();
        }

        public void BindData()
        {
            StuScore[] list = bll.GetScore(sc, out msg);
            if (msg != "")
            {
                MessageBox.Show(msg);
            }

            dgvStuScore.DataSource = list;



        }

    }
}

