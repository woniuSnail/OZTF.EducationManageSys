using MediatR;
using OZTF.EducationManageSys.Application.Configuration.Commands;
using OZTF.EducationManageSys.Domain.Teachers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OZTF.EducationManageSys.Application.Teachers.AddTeacher
{
    public class AddTeacherCommandHandle : ICommandHandle<AddTeacherCommand>
    {
        private readonly ITeacherCheck _teacherCheck;

        private readonly ITeacherRepository _teacherRepository;
        public AddTeacherCommandHandle(ITeacherCheck teacherCheck,
            ITeacherRepository teacherRepository)
        {
            _teacherCheck = teacherCheck;
            _teacherRepository = teacherRepository;
        }

        public async Task<Unit> Handle(AddTeacherCommand request, CancellationToken cancellationToken)
        {
            var teacher = Teacher.Add(request.Name, request.TNumber, request.Birthday, request.Phone, request.Email, request.EntryTime, _teacherCheck);
            await _teacherRepository.AddAsync(teacher);
            return Unit.Value;
        }
    }
}
