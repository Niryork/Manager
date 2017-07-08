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
    public partial class frmSubject : Form
    {
        BLLSubject bll = new BLLSubject();
        string msg;
        public frmSubject()
        {
            InitializeComponent();
        }

        private void frmSubject_Load(object sender, EventArgs e)
        {
            BindData();
        }

        private void BindData()
        {
            Subject sub = new Subject();
            sub.SubjectName = txtSubjectName.Text;

            Subject[] list = bll.GetSubject(sub, out msg);
            if (msg!= "")
            {
                MessageBox.Show(msg);
            }
            if (list == null)
            {
                list = new Subject[0];
            }
            dgvSubject.DataSource = list;

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            BindData();
        }

        int subjuctid;
        string subname = "";
        private void dgvSubject_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            subjuctid = Convert.ToInt32(dgvSubject.SelectedRows[0].Cells["ID"].Value);
            subname = Convert.ToString(dgvSubject.SelectedRows[0].Cells["SubjectName"].Value);
        }

        private void dgvSubject_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Subject sub = new Subject();
            int op;
            string Show = "";
            int newsubjectid = Convert.ToInt32(dgvSubject.Rows[e.RowIndex].Cells["ID"].Value);
            string newsubjectname = Convert.ToString(dgvSubject.Rows[e.RowIndex].Cells["SubjectName"].Value);
            if (subjuctid != 0)
            {
                op = 0;
                Show = "修改";
            }
            else
            {
                op = 1;
                Show = "添加";
            }
            if (newsubjectname == "")
            {
                MessageBox.Show("课程名字不能为空");
                dgvSubject.Rows[e.RowIndex].Cells["SubjectName"].Value = subname;
                return;
            }
            if (subname.Trim() != newsubjectname.Trim())
            {
                if (MessageBox.Show("是否" + Show + "课程", Show + "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.No)
                {
                    dgvSubject.Rows[e.RowIndex].Cells["SubjectName"].Value = subname;
                    return;
                }
                sub.ID = newsubjectid;
                sub.SubjectName = newsubjectname;
                bool isok = bll.SubEdit(sub, op, out msg);
                if (msg != "")
                {
                    MessageBox.Show(msg);
                }
                if (isok)
                {
                    MessageBox.Show(Show + "成功");
                    BindData();
                }
                else
                {
                    MessageBox.Show(Show + "失败");
                }

            }

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            Subject sub = new Subject();
            sub.ID = Convert.ToInt32(dgvSubject.SelectedRows[0].Cells["SubjectID"].Value.ToString());
            bool isok = bll.SubEdit(sub, 2, out msg);
            if (msg != "")
            {
                MessageBox.Show(msg);
            }
            if (isok)
            {
                MessageBox.Show("删除成功");
                BindData();
            }
            else
            {
                MessageBox.Show("删除失败");
            }

        }
    }
}
