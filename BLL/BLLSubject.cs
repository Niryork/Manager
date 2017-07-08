using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using StudentManage.DAL;
using StudentManage.Model;

namespace StudentManage.BLL
{
    public class BLLSubject
    {
        DALSubject dal = new DALSubject();


        public Subject[] GetSubject(Subject sub,out string msg)
        {
            return dal.GetSubject(sub, true, out msg);
        }

        public bool SubEdit(Subject sub,int op, out string msg)
        {
            int result = dal.SubEdit(sub, op, out msg);
            if (result>1)
            {
                return true;
            }
            return false;
        }

    }
}
