using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using StudentManage.Model;

namespace StudentManage.DAL
{
    public class DALScore
    {
        SqlHelper sh = new SqlHelper();
        /// 获取成绩表
        /// </summary>
        /// <param name="sc"></param>
        /// <param name="IsLike">判断模糊查询</param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public StuScore[] GetScore(StuScore sc, bool IsLike, out string msg)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("select * from V_Scores where 1=1 ");
            if (IsLike)
            {
                if (!string.IsNullOrEmpty(sc.SNO))
                {
                    sb.AppendFormat(" and sno like '%{0}%' ", sc.SNO);
                }
                if (!string.IsNullOrEmpty(sc.SubjectName))
                {
                    sb.AppendFormat(" and SubjectName like '%{0}%'", sc.SubjectName);
                }
            }
            else
            if (!string.IsNullOrEmpty(sc.SNO))
            {
                sb.AppendFormat(" and sno = '{0}'", sc.SNO);
            }
            if (!string.IsNullOrEmpty(sc.SubjectName))
            {
                sb.AppendFormat(" and SubjectName = '{0}'", sc.SubjectName);
            }

            DataTable dt = sh.ExecuteDataAdapter(sb.ToString(), out msg);

            if (dt != null && dt.Rows.Count > 0)
            {
                StuScore[] list = new StuScore[dt.Rows.Count+1];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    StuScore s = new StuScore();
                    s.ID = Convert.ToInt32(dt.Rows[i]["ID"]);
                    s.SubjectID = Convert.ToInt32(dt.Rows[i]["SubjectID"]);
                    s.SNO = dt.Rows[i]["SNO"].ToString();
                    s.StuName = dt.Rows[i]["StuName"].ToString();
                    s.SubjectName = dt.Rows[i]["SubjectName"].ToString();
                    s.Score = dt.Rows[i]["Score"] == DBNull.Value ? 0 : Convert.ToInt32(dt.Rows[i]["Score"]);

                    list[i] = s;
                }

                StuScore ss = new StuScore();
                ss.ID = 0;
                list[list.Length - 1] = ss;

                return list;
            }
            return null;

        }

        /// <summary>
        /// 提交执行增删改的数据
        /// </summary>
        /// <param name="sc"></param>
        /// <param name="op">0-删除，1-添加，2-修改</param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public int ScEdit(StuScore sc, int op, out string msg)
        {
            StringBuilder sb = new StringBuilder();

            switch (op)
            {
                case 0:
                    sb.AppendFormat("delete from Score where sno={0} and subjectid = {1}", sc.SNO,sc.SubjectID);
                    break;
                case 1:
                    sb.AppendFormat("insert into Score(sno,score,score,subjectID) values('{0}','{1}','{2}','{3}') ", sc.SNO, sc.Score, sc.Score, sc.SubjectID);
                    sb.AppendFormat("insert into Stuinfo(sno,stuname) values('{0}','{1}')", sc.SNO, sc.StuName);
                    break;
                case 2:
                    sb.AppendFormat("update Score set  Score ='{0}' where subjectid={1} and sno = {2}", sc.Score, sc.SubjectID,sc.SNO);
                    break;
                default:
                    msg = "输入的操作无法识别";
                    return 0;
            }

            return sh.ExecuteNonquery(sb.ToString(), out msg);
        }





    }
}
