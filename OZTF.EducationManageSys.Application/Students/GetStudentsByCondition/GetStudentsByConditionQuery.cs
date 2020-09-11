using OZTF.EducationManageSys.Application.Configuration.Queries;
using OZTF.EducationManageSys.Application.Students.Dto;
using System.Collections;
using System.Collections.Generic;

namespace OZTF.EducationManageSys.Application.Students.GetStudentsByCondition
{
    public class GetStudentsByConditionQuery : IQuery<IEnumerable<StudentDto>>
    {
        public string SNumber { get; set; }

        public string Name { get; set; }

        public int PageSize { get; set; }

        public int CurrentPage { get; set; }

        public GetStudentsByConditionQuery(string sNumber, string name, int pageSize, int currentPage)
        {
            SNumber = sNumber;
            Name = name;
            PageSize = pageSize;
            CurrentPage = currentPage;
        }
    }
}
