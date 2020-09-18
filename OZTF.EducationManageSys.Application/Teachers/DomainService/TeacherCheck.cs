using OZTF.EducationManageSys.Domain.Teachers;

namespace OZTF.EducationManageSys.Application.Teachers.DomainService
{
    public class TeacherCheck : ITeacherCheck
    {
        public bool IsEmailNull(string studentEmail)
        {
            return true;
        }

        public bool IsEmailUnique(string teacherEmail)
        {
            return true;
        }
    }
}
