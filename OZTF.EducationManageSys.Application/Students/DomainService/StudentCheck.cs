using OZTF.EducationManageSys.Domain.Students;

namespace OZTF.EducationManageSys.Application.Students.DomainService
{
    public class StudentCheck : IStudentCheck
    {
        public StudentCheck()
        {

        }

        public bool IsEmailNull(string studentEmail)
        {
            return true;
        }

        public bool IsEmailUnique(string studentEmail)
        {
            return true;
        }
    }
}
