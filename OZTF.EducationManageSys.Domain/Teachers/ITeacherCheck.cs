using System;
using System.Collections.Generic;
using System.Text;

namespace OZTF.EducationManageSys.Domain.Teachers
{
    public interface ITeacherCheck
    {
        /// <summary>
        /// 验证邮箱地址是否存在
        /// </summary>
        /// <param name="teacherEmail"></param>
        /// <returns></returns>
        bool IsEmailUnique(string teacherEmail);

        /// <summary>
        /// 验证邮箱地址是否为空
        /// </summary>
        /// <param name="studentEmail"></param>
        /// <returns></returns>
        bool IsEmailNull(string studentEmail);
    }
}
