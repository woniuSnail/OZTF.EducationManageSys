using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OZTF.EducationManageSys.Domain.Teachers
{
    public interface ITeacherRepository
    {
        /// <summary>
        /// 获取教师
        /// </summary>
        /// <returns></returns>
        Task<Teacher> GetAsync(Guid id);

        /// <summary>
        /// 添加教师
        /// </summary>
        /// <returns></returns>
        Task AddAsync(Teacher teacher);
    }
}
