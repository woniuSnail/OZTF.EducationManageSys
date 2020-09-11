using OZTF.EducationManageSys.Application.Configuration.Commands;
using OZTF.EducationManageSys.Application.Students.Dto;
using OZTF.EducationManageSys.Domain.Students;
using OZTF.EducationManageSys.Domain.Students.RuleInterfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OZTF.EducationManageSys.Application.Students.AddStudent
{
    public class AddStudentCommandHandle : ICommandHandle<AddStudentCommand, StudentDto>
    {
        private readonly IStudentCheck _studentUniqueCheck;

        private readonly IStudentRepository _studentRepository;

        public AddStudentCommandHandle(IStudentCheck studentUniqueCheck,
            IStudentRepository studentRepository)
        {
            _studentUniqueCheck = studentUniqueCheck;
            _studentRepository = studentRepository;
        }

        public async Task<StudentDto> Handle(AddStudentCommand request, CancellationToken cancellationToken)
        {
            var student = Student.AddStudent(request.SNumber, request.Name, request.Birthday, request.Phone, request.Email, request.AdmissionTime, _studentUniqueCheck);

            await _studentRepository.AddAsync(student);

            return new StudentDto(student.Id, request.SNumber, request.Name, request.Email, request.Phone, request.AdmissionTime, request.Birthday);
        }
    }
}
