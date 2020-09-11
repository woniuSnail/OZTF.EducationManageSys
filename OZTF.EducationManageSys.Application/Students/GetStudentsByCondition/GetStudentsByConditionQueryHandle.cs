using OZTF.EducationManageSys.Application.Configuration.Data;
using OZTF.EducationManageSys.Application.Configuration.Queries;
using OZTF.EducationManageSys.Application.Students.Dto;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace OZTF.EducationManageSys.Application.Students.GetStudentsByCondition
{
    public class GetStudentsByConditionQueryHandle : IQueryHandle<GetStudentsByConditionQuery, IEnumerable<StudentDto>>
    {
        private readonly ISqlConnectionFactory _sqlConnectionFactory;
        public GetStudentsByConditionQueryHandle(ISqlConnectionFactory sqlConnectionFactory)
        {
            _sqlConnectionFactory = sqlConnectionFactory;
        }
        public Task<IEnumerable<StudentDto>> Handle(GetStudentsByConditionQuery request, CancellationToken cancellationToken)
        {
            //通过条件获取学生
            
            return null;
        }
    }
}
