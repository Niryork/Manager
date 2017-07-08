using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using StudentManage.DAL;
using StudentManage.Model;

namespace StudentManage.BLL
{
    public class BLLStuinfo
    {
        DALStuinfo dal = new DALStuinfo();
        public Stuinfo[] GetStuInfoList(Stuinfo stu, out string msg)
        {
            Stuinfo[] list = dal.GetStuInfoList(stu, true, out msg);

            return list;
        }


        public bool IsLoginSuccess(Stuinfo stu, out string msg)
        {
            int result = dal.Islogin(stu, out msg);

            if (result>0)
            {
                return true;
            }
            return false;
        }

        public Stuinfo GetStuInfo(Stuinfo stu, out string msg)
        {
            Stuinfo[] list = dal.GetStuInfoList(stu, false, out msg);

            if (list != null)
            {
                Stuinfo s = list[0];
                return s;
            }
            return null;
        }

        public bool IsUpdateSucces(Stuinfo stu, out string msg)
        {
            int result = dal.UpDateStuInfo(stu, out msg);
            if (result > 0)
            {
                return true;
            }
            return false;
        }
        public bool Delete(Stuinfo stu,out string msg)
        {
            int result = dal.Delete(stu, out msg);
            if (result > 0)
            {
                return true;
            }
            return false;
        }

        //public bool InsertIsNull(Stuinfo stu)
        //{
        //    // bool result = dal.InsertIsNull(stu);
        //    //return result;
        //}

    }
}
