using MediatR;
using OZTF.EducationManageSys.Application.Configuration.Commands;
using OZTF.EducationManageSys.Domain.Students;
using OZTF.EducationManageSys.Domain.Students.RuleInterfaces;
using System.Threading;
using System.Threading.Tasks;

namespace OZTF.EducationManageSys.Application.Students.UpdateStudent
{
    public class UpdateStudentCommandHandle : ICommandHandle<UpdateStudentCommand>
    {
        private readonly IStudentRepository _studentRepository;

        private readonly IStudentCheck _studentCheck;
        public UpdateStudentCommandHandle(IStudentRepository studentRepository,
            IStudentCheck studentCheck)
        {
            _studentRepository = studentRepository;
            _studentCheck = studentCheck;
        }
        public async Task<Unit> Handle(UpdateStudentCommand request, CancellationToken cancellationToken)
        {
            var student = await _studentRepository.GetByIdAsync(request.Id);

            student?.UpdateStudent(request.SNumber, request.Name, request.Birthday, request.Phone, request.Email, request.AdmissionTime, _studentCheck);
            
            return Unit.Value;
        }
    }
}
