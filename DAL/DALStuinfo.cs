using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using StudentManage.Model;
using System.Data.SqlClient;

namespace StudentManage.DAL
{
    public class DALStuinfo
    {
        SqlHelper sh = new SqlHelper();

        #region 学生信息
        /// <summary>
        /// 获取学生信息
        /// </summary>
        /// <param name="stu"></param>
        /// <param name="isLike"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public Stuinfo[] GetStuInfoList(Stuinfo stu, bool isLike, out string msg)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("select * from stuinfo where 1=1 ");
            if (isLike)
            {
                //不显示admin这一行的值
                sb.Append(" and sno <> 'admin' ");

                if (!string.IsNullOrEmpty(stu.SNO))
                {
                    sb.AppendFormat(" and sno like '%{0}%'", stu.SNO);
                }
            }
            else
            {
                sb.AppendFormat("and sno = '{0}'", stu.SNO);
            }

            if (!string.IsNullOrEmpty(stu.StuName))
            {
                sb.AppendFormat(" and stuname like '%{0}%'", stu.StuName);
            }



            DataTable dt = sh.ExecuteDataAdapter(sb.ToString(), out msg);

            if (dt != null && dt.Rows.Count > 0)
            {
                Stuinfo[] list = new Stuinfo[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Stuinfo s = new Stuinfo();
                    s.SNO = dt.Rows[i]["SNO"].ToString();
                    s.Pwd = dt.Rows[i]["pwd"].ToString();
                    s.StuName = dt.Rows[i]["StuName"].ToString();
                    s.Sex = dt.Rows[i]["Sex"].ToString();

                    s.Age = dt.Rows[i]["Age"] == DBNull.Value ? 0 : Convert.ToInt32(dt.Rows[i]["Age"]);
                    s.Address = dt.Rows[i]["Address"] == DBNull.Value ? "" : dt.Rows[i]["Address"].ToString();
                    s.Role = dt.Rows[i]["Role"] == DBNull.Value ? 0 : Convert.ToInt32(dt.Rows[i]["Role"]);
                    s.BirthDay = dt.Rows[i]["BirthDay"] == DBNull.Value ? DateTime.Now.AddYears(-150) : Convert.ToDateTime(dt.Rows[i]["BirthDay"]);

                    list[i] = s;
                }
                return list;

            }
            return null;

        }

        public int Islogin(Stuinfo stu, out string msg)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("select count(1) from stuInfo where 1=1");

            SqlParameter sqsno = new SqlParameter("@sno", stu.SNO);
            SqlParameter sqpwd = new SqlParameter("@pwd", stu.Pwd);
            SqlParameter[] sqlist = { sqsno, sqpwd };

            return Convert.ToInt32(sh.ExecuteScalar(sb.ToString(),sqlist,out msg));

        }


        /// <summary>
        /// 提交已编辑学生信息
        /// </summary>
        /// <param name="stu"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public int UpDateStuInfo(Stuinfo stu, out string msg)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("update stuinfo set ");

            #region 插入数据
            if (!string.IsNullOrEmpty(stu.Pwd))
            {
                sb.AppendFormat(" pwd = '{0}',", stu.Pwd);
            }
            if (!string.IsNullOrEmpty(stu.StuName))
            {
                sb.AppendFormat(" StuName = '{0}',", stu.StuName);
            }
            if (!string.IsNullOrEmpty(stu.Age.ToString()))
            {
                sb.AppendFormat(" Age = '{0}',", stu.Age);
            }
            if (!string.IsNullOrEmpty(stu.Sex))
            {
                sb.AppendFormat(" Sex = '{0}',", stu.Sex);
            }
            if (!string.IsNullOrEmpty(stu.Address))
            {
                sb.AppendFormat(" Address = '{0}',", stu.Address);
            }
            if (!string.IsNullOrEmpty(stu.BirthDay.ToString()))
            {
                sb.AppendFormat(" BirthDay = '{0}',", stu.BirthDay);
            }
            sb.Remove(sb.Length - 1, 1);

            #endregion

            if (!string.IsNullOrEmpty(stu.SNO))
            {
                sb.AppendFormat(" where sno = '{0}' ", stu.SNO);
            }
            int result = sh.ExecuteNonquery(sb.ToString(), out msg);
            return result;
        }

        /// <summary>
        /// 提交执行增删改的数据
        /// </summary>
        /// <param name="sc"></param>
        /// <param name="op">0-删除，1-添加，2-修改</param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public int StuEdit(Stuinfo stu, int op, out string msg)
        {
            StringBuilder sb = new StringBuilder();

            switch (op)
            {
                case 0:
                    sb.AppendFormat("delete from Stuinfo where SNO={0}", stu.SNO);
                    break;
                case 1:


                    sb.AppendFormat("insert into Stuinfo values('{0}',", stu.SNO);
                    sb.AppendFormat("{0},", stu.Age);
                    sb.AppendFormat("{0},", stu.StuName);
                    sb.AppendFormat("{0},", stu.Sex);
                    sb.AppendFormat("{0},", stu.Address);
                    sb.AppendFormat("{0},)", stu.BirthDay);
                    break;
                case 2:
                    sb.AppendFormat("update Stuinfo set  Age = '{0}' ", stu.Age);
                    sb.AppendFormat(" and StuName = '{0}'", stu.StuName);
                    sb.AppendFormat("and Address = '{0}'", stu.Address);
                    sb.AppendFormat("and BirthDay = '{0}'", stu.BirthDay);
                    sb.AppendFormat(" where sno = '{0}'", stu.SNO);
                    break;
                default:
                    msg = "输入的操作无法识别";
                    return 0;
            }

            return sh.ExecuteNonquery(sb.ToString(), out msg);
        }




        /// <summary>
        /// 删除一条选中信息
        /// </summary>
        /// <param name="stu"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public int Delete(Stuinfo stu, out string msg)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("delete  from stuinfo where ");
            if (!string.IsNullOrEmpty(stu.SNO))
            {
                sb.AppendFormat(" sno = '{0}'", stu.SNO);
            }
            int result = sh.ExecuteNonquery(sb.ToString(), out msg);
            return result;
        }

        //public int SNoIsEmpty(Stuinfo stu, out string msg)
        //{
        //    StringBuilder ss = new StringBuilder();
        //    ss.Append("select top 1 from stuinfo group by sno");
        //    string sno = Convert.ToString(sh.ExecuteScalar(ss.ToString(), out msg));
        //    if (sno != "10001")
        //    {

        //    }

        //}

        #endregion  
            
    }
}
