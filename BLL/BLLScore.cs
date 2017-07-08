using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using StudentManage.DAL;
using StudentManage.Model;

namespace StudentManage.BLL
{
    public class BLLScore
    {
        DALScore dal = new DALScore();
        /// <summary>
        /// 获取成绩数组数据
        /// </summary>
        /// <param name="sc"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public StuScore[] GetScore(StuScore sc, out string msg)
        {
            return dal.GetScore(sc, true, out msg);

        }
        /// <summary>
        /// 执行变更
        /// </summary>
        /// <param name="sc"></param>
        /// <param name="op">0-删除，1-添加，2-修改</param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public bool ScEdit(StuScore sc ,int op,out string msg)
        {
            int result = dal.ScEdit(sc, op, out msg);
            if (result>0)
            {
                return true;
            }
            return false;
        }


    }
}
