using Dapper;
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
        public async Task<IEnumerable<StudentDto>> Handle(GetStudentsByConditionQuery request, CancellationToken cancellationToken)
        {
            var students = await GetStudentsAsync(request);
            return students;
        }

        private Task<IEnumerable<StudentDto>> GetStudentsAsync(GetStudentsByConditionQuery request)
        {
            var strWhere = "";
            if (!string.IsNullOrEmpty(request.Name))
            {
                strWhere += " and Name=@Name ";
            }
            if(!string.IsNullOrEmpty(request.SNumber))
            {
                strWhere += " and SNumber=@SNumber ";
            }

            var sql = $@"select Id,SNumber,Name,Email,Phone,AdmissionTime,Birthday from student where 1=1 { strWhere } 
                    order by AddTime desc limit {request.PageSize * request.CurrentPage},{ request.PageSize * (request.CurrentPage + 1)}";

            //通过条件获取学生
            return _sqlConnectionFactory.GetOpenConnection().QueryAsync<StudentDto>(sql, request);
        }
    }
}
