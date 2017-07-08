using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentManage.Model
{

    /// <summary>
    /// 学生课程管理
    /// </summary>
    public partial class Subject
    {
        public Subject()
        { }
        #region Subject.Model
        private int _id;
        private string _subjectname;
        /// <summary>
        /// 
        /// </summary>
        public int ID
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string SubjectName
        {
            set { _subjectname = value; }
            get { return _subjectname; }
        }
        #endregion Subject.Model

    }
}
