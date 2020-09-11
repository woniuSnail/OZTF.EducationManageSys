using OZTF.EducationManageSys.Domain.SeedWork;

namespace OZTF.EducationManageSys.Domain.Students.Rules
{
    public class StudentEmailRule : IBusinessRule
    {
        private readonly IStudentCheck _studentCheck;

        private readonly string _studentEmail;

        public StudentEmailRule(IStudentCheck studentCheck,
            string studentEmail)
        {
            _studentCheck = studentCheck;
            _studentEmail = studentEmail;
        }


        public string Message { get; set; }

        public int ErrorCode { get; set; }

        public bool IsPass()
        {
            var result = false;
            if(_studentCheck.IsEmailNull(_studentEmail))
            {
                Message = "邮箱地址是空";
                ErrorCode = 1001;
                result = false;
            }
            else if (!_studentCheck.IsEmailUnique(_studentEmail))
            {
                Message = "邮箱地址已存在";
                ErrorCode = 1002;
                result = false;
            }
            else
            {
                result = true;
            }
            return result;
        }
    }
}
