using MediatR;
using OZTF.EducationManageSys.Application.Configuration.Commands;
using OZTF.EducationManageSys.Domain.SeedWork;
using OZTF.EducationManageSys.Domain.Students;
using System.Threading;
using System.Threading.Tasks;

namespace OZTF.EducationManageSys.Application.Students.RemoveStudent
{
    public class RemoveStudentCommandHandle : ICommandHandle<RemoveStudentCommand>
    {
        private readonly IStudentRepository _studentRepository;

        private readonly IUnitOfWork _unitOfWork;

        public RemoveStudentCommandHandle(IStudentRepository studentRepository,
            IUnitOfWork unitOfWork)
        {
            _studentRepository = studentRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(RemoveStudentCommand request, CancellationToken cancellationToken)
        {
            var student = await _studentRepository.GetByIdAsync(request.Id);
            student.RemoveStudent();
            await _unitOfWork.ComitAsync(cancellationToken);
            return Unit.Value;
        }
    }
}
