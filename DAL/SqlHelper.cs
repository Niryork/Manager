using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace StudentManage.DAL
{

    public class SqlHelper
    {
        string connstr = string.Format(@"{0}", ConfigurationManager.ConnectionStrings["sa"].ConnectionString);

        #region 返回首行首列
        /// <summary>
        /// 返回首行首列
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public object ExecuteScalar(string sql, out string msg)
        {
            return ExecuteScalar(sql, null, out msg);

        }
        /// <summary>
        /// 返回首行首列
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="splist"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public object ExecuteScalar(string sql, SqlParameter[] splist, out string msg)
        {
            msg = "";
            try
            {
                //1.1.创建连接对象
                SqlConnection conn = new SqlConnection(connstr);

                //1.2.打开连接
                conn.Open();

                //1.3.创建数据库命令对象,输入请求数据库的命令
                //sql注入
                SqlCommand cmd = new SqlCommand(sql, conn);
                if (splist != null)
                {
                    cmd.Parameters.AddRange(splist);
                }

                //1.4.执行命令，并返回结果
                object obj = cmd.ExecuteScalar();

                //1.5.关闭连接
                conn.Close();

                return obj;
            }
            catch (Exception ex)
            {
                msg = ex.Message;
                return "";

            }




        }
        #endregion

        #region 执行增删改

        /// <summary>
        /// 执行增删改
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="splist"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public int ExecuteNonquery(string sql, out string msg)
        {
            return ExecuteNonquery(sql, null,out msg);
        }
        /// <summary>
        /// 执行增删改
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="splist"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public int ExecuteNonquery(string sql, SqlParameter[] splist, out string msg)
        {
            try
            {
                msg = "";
                SqlConnection conn = new SqlConnection(connstr);

                conn.Open();

                SqlCommand cmd = new SqlCommand(sql, conn);

                if (splist != null)
                {
                    cmd.Parameters.AddRange(splist);
                }
                int result = cmd.ExecuteNonQuery();
                return result;
            }
            catch (Exception ex)
            {
                msg = ex.Message;
                return 0;
            }
        }
        #endregion

        #region 返回多行多列
        /// <summary>
        /// 返回多行多列
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="splist"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public DataTable ExecuteDataAdapter(string sql, out string msg)
        {
            return ExecuteDataAdapter(sql, null,out msg);
        }
        /// <summary>
        /// 返回多行多列
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="splist"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public DataTable ExecuteDataAdapter(string sql, SqlParameter[] splist, out string msg)
        {
            msg = "";
            try
            {
                SqlConnection conn = new SqlConnection(connstr);

                conn.Open();

                SqlCommand cmd = new SqlCommand(sql, conn);

                if (splist != null)
                {
                    cmd.Parameters.AddRange(splist);
                }

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                conn.Close();

                return dt;
            }
            catch (Exception ex)
            {
                msg = ex.Message;
                return null;
            }

        }
        #endregion
    }
}
