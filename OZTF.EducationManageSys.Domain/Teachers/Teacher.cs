using OZTF.EducationManageSys.Domain.SeedWork;
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

        public Teacher(Guid? id, string name, DateTime birthday, string phone, string email, DateTime? entryTime)
        {
            Id = id ?? Guid.NewGuid();
            _name = name;
            _birthday = birthday;
            _phone = phone;
            _email = email;
            _entryTime = entryTime;

        }
    }
}
