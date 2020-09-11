using System;
using System.Collections.Generic;
using System.Text;

namespace OZTF.EducationManageSys.Domain.Students
{
    public interface IStudentCheck
    {
        /// <summary>
        /// 验证邮箱地址是否存在
        /// </summary>
        /// <param name="studentEmail"></param>
        /// <returns></returns>
        bool IsEmailUnique(string studentEmail);

        /// <summary>
        /// 验证邮箱地址是否为空
        /// </summary>
        /// <param name="studentEmail"></param>
        /// <returns></returns>
        bool IsEmailNull(string studentEmail);


    }
}
