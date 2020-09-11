using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OZTF.EducationManageSys.Domain.Students
{
    public interface IStudentRepository
    {
        /// <summary>
        /// 添加学生
        /// </summary>
        /// <param name="student"></param>
        /// <returns></returns>
        Task AddAsync(Student student);

        /// <summary>
        /// 获取学生对象
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<Student> GetByIdAsync(Guid id);
    }
}
