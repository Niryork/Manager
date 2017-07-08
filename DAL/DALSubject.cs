using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using System.Data.SqlClient;
using StudentManage.Model;

namespace StudentManage.DAL
{
    public class DALSubject
    {
        SqlHelper sh = new SqlHelper();

        public Subject[] GetSubject(Subject sub, bool Islike, out string msg)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("select * from Subject where 1=1");
            if (Islike)
            {
                sb.AppendFormat(" and subjectname like '%{0}%'", sub.SubjectName);
            }

            DataTable dt = sh.ExecuteDataAdapter(sb.ToString(), out msg);

            if (dt != null && dt.Rows.Count > 0)
            {
                Subject[] list = new Subject[dt.Rows.Count + 1];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Subject ss = new Subject();
                    ss.SubjectName = dt.Rows[i]["SubjectName"].ToString();
                    ss.ID = Convert.ToInt32(dt.Rows[i]["ID"]);

                    list[i] = ss;

                }
                return list;
            }
            return null;
        }

        public int SubEdit(Subject sub,int op,out string msg)
        {
            StringBuilder sb = new StringBuilder();

            switch (op)
            {
                case 0:sb.AppendFormat("delete from Subject where subjectname = '{0}'",sub.SubjectName);
                    break;
                case 1:sb.AppendFormat("insert into subject(subjectname) values ('{0}')",sub.SubjectName);
                    break;
                case 2:sb.AppendFormat("update subject set subjectname = '{0}'", sub.SubjectName);
                    break;
                default:
                    msg = "输入无法识别";
                    return 0;                  
            }
            return sh.ExecuteNonquery(sb.ToString(), out msg);
        }

    }
}
