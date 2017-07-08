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
    public partial class frmScoreManage : Form
    {
        BLLScore bll = new BLLScore();
        string msg;
        public frmScoreManage()
        {
            InitializeComponent();
        }

        private void frmScoreManage_Load(object sender, EventArgs e)
        {
            BindData();
        }
        public void BindData()
        {
            StuScore sc = new StuScore();
            sc.SNO = txtSNO.Text;
            sc.SubjectName = txtSubjectName.Text;

            StuScore[] list = bll.GetScore(sc, out msg);
            if (msg != "")
            {
                MessageBox.Show(msg);
            }

            dgvScoreManage.DataSource = list;

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            BindData();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("是否确认删除", "删除提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == System.Windows.Forms.DialogResult.Yes)
            {
                StuScore s = new StuScore();
                if (true)
                {
                    s.SNO = dgvScoreManage.SelectedRows[0].Cells["SNO"].Value.ToString();

                }
                bool result = bll.ScEdit(s, 0, out msg);
                if (msg != "")
                {
                    MessageBox.Show(msg);
                }

                if (result)
                {
                    MessageBox.Show("删除成功");
                    BindData();
                }
                MessageBox.Show("删除失败");
            }

        }

        #region 获取原来单元格内的值
        int OldScore = 0;
        string OldSubjectName = "";
        string OldSubID = "";
        string OldStuName;
        string OldSNO;

        #endregion

        private void dgvScoreManage_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            OldScore = Convert.ToInt32(dgvScoreManage.Rows[e.RowIndex].Cells["Score"].Value);
            OldSubjectName = Convert.ToString(dgvScoreManage.Rows[e.RowIndex].Cells["SubjectName"].Value);
            OldStuName = Convert.ToString(dgvScoreManage.Rows[e.RowIndex].Cells["StuName"].Value);
            OldSNO = Convert.ToString(dgvScoreManage.Rows[e.RowIndex].Cells["SNO"].Value);
            OldSubID = Convert.ToString(dgvScoreManage.Rows[e.RowIndex].Cells["SubjectID"].Value);
        }

        private void dgvScoreManage_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            bool isUpdateOP = true;//默认是【修改】操作
            int id = Convert.ToInt32(dgvScoreManage.Rows[e.RowIndex].Cells["ID"].Value);

            string opStr = "修改";
            if (id == 0)
            {
                opStr = "添加";
                isUpdateOP = false;
                dgvScoreManage.Rows[e.RowIndex].Cells["SNO"].Value = Convert.ToString((Convert.ToInt32(dgvScoreManage.Rows[e.RowIndex - 1].Cells["SNO"].Value) + 1));

            }

            //自增学号
            #region 不能修改已存在的列
            string sno = Convert.ToString(dgvScoreManage.Rows[e.RowIndex].Cells["SNO"].Value);
            string newStuName = Convert.ToString(dgvScoreManage.Rows[e.RowIndex].Cells["StuName"].Value);
            string NewSubjectName = Convert.ToString(dgvScoreManage.Rows[e.RowIndex].Cells["SubjectName"].Value);

            //学号不能修改
            if (NonEdit(isUpdateOP, sno, OldSNO, "学号", "SNO", e))
            {
                return;
            }

            //姓名不能修改
            if (NonEdit(isUpdateOP, newStuName, OldStuName, "姓名", "StuName", e))
            {
                return;
            }

            // 学科名
            if (NonEdit(isUpdateOP, NewSubjectName, OldSubjectName, "学科名", "SubjectName", e))
            {
                return;
            }

            #endregion

            int newScore = Convert.ToInt32(dgvScoreManage.Rows[e.RowIndex].Cells["Score"].Value);

            if (newScore != OldScore)
            {
                if (newScore > 100 || newScore < 0)
                {
                    MessageBox.Show("你输入的成绩有误，请重新输入");
                    dgvScoreManage.Rows[e.RowIndex].Cells["Score"].Value = OldScore;
                    return;
                }
                if (isUpdateOP)
                {
                    if (MessageBox.Show("请确认是否要修改该成绩", "修改提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                    {
                        dgvScoreManage.Rows[e.RowIndex].Cells["Score"].Value = OldScore;
                        return;
                    }

                }
            }



            StuScore ss = new StuScore();
            ss.SubjectName = NewSubjectName;
            ss.Score = newScore;
            ss.StuName = newStuName;
            ss.SNO = sno;
            ss.SubjectID = Convert.ToInt32(dgvScoreManage.Rows[e.RowIndex].Cells["SubjectID"].Value);
            ss.ID = Convert.ToInt32(dgvScoreManage.Rows[e.RowIndex].Cells["ID"].Value);


            bool isOK;
            if (!isUpdateOP)
            {
                //新增
                isOK = bll.ScEdit(ss, 1, out msg);
            }
            else
            {
                //修改
                isOK = bll.ScEdit(ss, 2, out msg);
            }

            if (msg != "")
            {
                MessageBox.Show(msg);
            }


            if (isOK)
            {
                MessageBox.Show(opStr + "成功");
                t_Fresh.Enabled = true;
            }
            else
            {
                //将原来的值还原，并提示错误
                dgvScoreManage.Rows[e.RowIndex].Cells["SubjectName"].Value = OldSubjectName;
                dgvScoreManage.Rows[e.RowIndex].Cells["Score"].Value = OldScore;
                dgvScoreManage.Rows[e.RowIndex].Cells["StuName"].Value = OldStuName;
                dgvScoreManage.Rows[e.RowIndex].Cells["SNO"].Value = OldSNO;
                MessageBox.Show("输入的数据有误，请重新确认");
            }
        }

        private void t_Fresh_Tick(object sender, EventArgs e)
        {
            BindData();
            t_Fresh.Enabled = false;
        }

        /// <summary>
        /// 不能修改的值
        /// </summary>
        /// <param name="Up">是否更新</param>
        /// <param name="newOne">新增列的值</param>
        /// <param name="OldOne">原来列的值</param>
        /// <param name="str">列名(显示的值)</param>
        /// <param name="Col">列名(隐藏的值)</param>
        /// <param name="e"></param>
        /// <returns></returns>
        private bool NonEdit(bool Up, string newOne, string OldOne, string str, string Col, DataGridViewCellEventArgs e)
        {

            if (Up)
            {
                if (newOne == "" || newOne != OldOne)
                {

                    if (!string.IsNullOrEmpty(OldOne))
                    {
                        MessageBox.Show(str + "不能修改");
                        dgvScoreManage.Rows[e.RowIndex].Cells[Col].Value = OldOne;
                        return true;
                    }
                }
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
