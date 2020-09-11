using OZTF.EducationManageSys.Domain.Students;
using OZTF.EducationManageSys.Infrastructure.DataBase;
using System;
using System.Threading.Tasks;

namespace OZTF.EducationManageSys.Infrastructure.Domain.Students
{
    public class StudentRepository : IStudentRepository
    {
        private readonly EducationContext _educationContext;

        public StudentRepository(EducationContext educationContext)
        {
            _educationContext = educationContext;
        }

        /// <summary>
        /// 添加学生
        /// </summary>
        /// <param name="student"></param>
        /// <returns></returns>
        public async Task AddAsync(Student student)
        {
            await _educationContext.Students.AddAsync(student);
        }

        /// <summary>
        /// 通过id获取学生对象
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<Student> GetByIdAsync(Guid id)
        {
            return await _educationContext.Students.FindAsync(id);
        }
    }
}
