using OZTF.EducationManageSys.Domain.SeedWork;
using OZTF.EducationManageSys.Domain.Teachers.Rules;
using System;

namespace OZTF.EducationManageSys.Domain.Teachers
{
    public class Teacher : Entity
    {
        /// <summary>
        /// Id
        /// </summary>
        public Guid Id { get; private set; }

        /// <summary>
        /// 姓名
        /// </summary>
        private string _name;

        /// <summary>
        /// 编号
        /// </summary>
        private string _tNumber;

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
        /// 入职时间
        /// </summary>
        private DateTime? _entryTime;

        private bool _dr;
        private DateTime _addTime;
        private DateTime? _updateTime;

        public Teacher(Guid? id, string tNumber, string name, DateTime birthday, string phone, string email, DateTime? entryTime)
        {
            Id = id ?? Guid.NewGuid();
            _tNumber = tNumber;
            _name = name;
            _birthday = birthday;
            _phone = phone;
            _email = email;
            _entryTime = entryTime;

        }

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="name"></param>
        /// <param name="tNumber"></param>
        /// <param name="birthday"></param>
        /// <param name="phone"></param>
        /// <param name="email"></param>
        /// <param name="entryTime"></param>
        /// <param name="teacherCheck"></param>
        public static Teacher Add(string name, string tNumber, DateTime birthday, string phone, string email, DateTime? entryTime, ITeacherCheck teacherCheck)
        {
            CheckRule(new TeacherEmailRule(teacherCheck, email));

            var teacher = new Teacher(null, tNumber, name, birthday, phone, email, entryTime);
            teacher._dr = false;
            teacher._addTime = DateTime.Now;
            teacher._updateTime = null;
            return teacher;
        }
    }
}
