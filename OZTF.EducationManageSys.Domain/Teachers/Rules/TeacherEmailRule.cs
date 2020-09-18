using OZTF.EducationManageSys.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace OZTF.EducationManageSys.Domain.Teachers.Rules
{
    public class TeacherEmailRule : IBusinessRule
    {
        private readonly ITeacherCheck _teacherCheck;

        private readonly string _teacherEmail;

        public TeacherEmailRule(ITeacherCheck teacherCheck, 
            string teacherEmail)
        {
            _teacherCheck = teacherCheck;
            _teacherEmail = teacherEmail;
        }

        public string Message { get; set; }

        public int ErrorCode { get; set; }

        public bool IsPass()
        {
            var result = true;
            if(_teacherCheck.IsEmailNull(_teacherEmail))
            {
                Message = "邮箱不能为空";
                ErrorCode = 1001;
                result = false;
            }
            if(_teacherCheck.IsEmailUnique(_teacherEmail))
            {
                Message = "邮箱不能重复";
                ErrorCode = 1002;
                result = false;
            }
            return result;
        }
    }
}
