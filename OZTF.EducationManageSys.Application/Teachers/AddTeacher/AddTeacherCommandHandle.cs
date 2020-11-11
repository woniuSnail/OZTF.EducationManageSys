using MediatR;
using OZTF.EducationManageSys.Application.Configuration.Commands;
using OZTF.EducationManageSys.Domain.SeedWork;
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

        private readonly IUnitOfWork _unitOfWork;

        public AddTeacherCommandHandle(ITeacherCheck teacherCheck,
            ITeacherRepository teacherRepository,
            IUnitOfWork unitOfWork)
        {
            _teacherCheck = teacherCheck;
            _teacherRepository = teacherRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(AddTeacherCommand request, CancellationToken cancellationToken)
        {
            var teacher = Teacher.Add(request.Name, request.TNumber, request.Birthday, request.Phone, request.Email, request.EntryTime, _teacherCheck);
            await _teacherRepository.AddAsync(teacher);
            await _unitOfWork.ComitAsync(cancellationToken);
            return Unit.Value;
        }
    }
}
