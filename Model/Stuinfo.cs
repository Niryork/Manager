using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentManage.Model
{
    /// <summary>
    /// 学生信息管理
    /// </summary>
    public partial class Stuinfo
    {
        public Stuinfo()
        { }
        #region Stuinfo.Model
        private string _sno;
        private string _pwd = "123456";
        private string _stuname;
        private int? _age = 0;
        private string _sex = "男";
        private string _address;
        private int? _role = 1;
        private DateTime? _birthday;
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
        public string Pwd
        {
            set { _pwd = value; }
            get { return _pwd; }
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
        public int? Age
        {
            set { _age = value; }
            get { return _age; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Sex
        {
            set { _sex = value; }
            get { return _sex; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Address
        {
            set { _address = value; }
            get { return _address; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? Role
        {
            set { _role = value; }
            get { return _role; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? BirthDay
        {
            set { _birthday = value; }
            get { return _birthday; }
        }
        #endregion Stuinfo.Model
    }
}
