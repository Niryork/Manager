using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace StudentManage.Model
{
    /// <summary>
    /// StuScore:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class StuScore
    {
        public StuScore()
        { }
        #region Model
        private int _id;
        private string _sno;
        private string _stuname;
        private int? _score;
        private string _subjectname;
        private int? _subjectid;
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
        public string SNO
        {
            set { _sno = value; }
            get { return _sno; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string StuName
        {
            set { _stuname = value; }
            get { return _stuname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? Score
        {
            set { _score = value; }
            get { return _score; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string SubjectName
        {
            set { _subjectname = value; }
            get { return _subjectname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? SubjectID
        {
            set { _subjectid = value; }
            get { return _subjectid; }
        }
        #endregion Model

    }
}

