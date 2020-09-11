using OZTF.EducationManageSys.Domain.SeedWork;
using OZTF.EducationManageSys.Domain.Students.Rules;
using System;

namespace OZTF.EducationManageSys.Domain.Students
{
    public class Student : Entity
    {
        /// <summary>
        /// Id
        /// </summary>
        public Guid Id { get; private set; }

        /// <summary>
        /// 学号
        /// </summary>
        private string _sNumber;
        
        /// <summary>
        /// 姓名
        /// </summary>
        private string _name; 
        
        /// <summary>
        /// 出生日期
        /// </summary>
        private DateTime _birthday;
        
        /// <summary>
        /// 联系电话
        /// </summary>
        private string _phone;
        
        /// <summary>
        /// 邮箱地址
        /// </summary>
        private string _email;
        
        /// <summary>
        /// 入学时间
        /// </summary>
        private DateTime? _admissionTime;
        
        private bool _dr;
        private DateTime _addTime;
        private DateTime? _updateTime;

        public Student(Guid? id, string sNumber, string name, DateTime birthday, string phone, string email, DateTime? admissionTime)
        {
            Id = id ?? Guid.NewGuid();
            _sNumber = sNumber;
            _name = name;
            _birthday = birthday;
            _phone = phone;
            _email = email;
            _admissionTime = admissionTime;
        }

        /// <summary>
        /// 添加学生
        /// </summary>
        /// <param name="sNumber"></param>
        /// <param name="name"></param>
        /// <param name="birthday"></param>
        /// <param name="phone"></param>
        /// <param name="email"></param>
        /// <param name="admissionTime"></param>
        /// <returns></returns>
        public static Student AddStudent(string sNumber, string name, DateTime birthday, string phone, string email, DateTime? admissionTime, IStudentCheck studentCheck)
        {
            CheckRule(new StudentEmailRule(studentCheck, email));

            var student = new Student(null, sNumber, name, birthday, phone, email, admissionTime);
            student._dr = false;
            student._addTime = DateTime.Now;
            student._updateTime = null;
            return student;
        }

        /// <summary>
        /// 修改学生信息
        /// </summary>
        /// <param name="sNumber"></param>
        /// <param name="name"></param>
        /// <param name="birthday"></param>
        /// <param name="phone"></param>
        /// <param name="email"></param>
        /// <param name="admissionTime"></param>
        /// <param name="studentCheck"></param>
        /// <returns></returns>
        public void UpdateStudent(string sNumber, string name, DateTime birthday, string phone, string email, DateTime? admissionTime, IStudentCheck studentCheck)
        {
            CheckRule(new StudentEmailRule(studentCheck, email));

            this._sNumber = sNumber;
            this._name = name;
            this._birthday = birthday;
            this._phone = phone;
            this._email = email;
            this._admissionTime = admissionTime;
            this._updateTime = DateTime.Now;

        }

        /// <summary>
        /// 移除学生
        /// </summary>
        /// <param name="id"></param>
        public void RemoveStudent()
        {
            this._dr = true;
        }
    }
}
