using MediatR;
using OZTF.EducationManageSys.Application.Configuration.Commands;
using OZTF.EducationManageSys.Domain.SeedWork;
using OZTF.EducationManageSys.Domain.Students;
using System.Threading;
using System.Threading.Tasks;

namespace OZTF.EducationManageSys.Application.Students.UpdateStudent
{
    public class UpdateStudentCommandHandle : ICommandHandle<UpdateStudentCommand>
    {
        private readonly IStudentRepository _studentRepository;

        private readonly IStudentCheck _studentCheck;

        private readonly IUnitOfWork _unitOfWork;

        public UpdateStudentCommandHandle(IStudentRepository studentRepository,
            IStudentCheck studentCheck,
            IUnitOfWork unitOfWork)
        {
            _studentRepository = studentRepository;
            _studentCheck = studentCheck;
            _unitOfWork = unitOfWork;

        }
        public async Task<Unit> Handle(UpdateStudentCommand request, CancellationToken cancellationToken)
        {
            var student = await _studentRepository.GetByIdAsync(request.Id);

            student?.UpdateStudent(request.SNumber, request.Name, request.Birthday, request.Phone, request.Email, request.AdmissionTime, _studentCheck);

            await _unitOfWork.ComitAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
