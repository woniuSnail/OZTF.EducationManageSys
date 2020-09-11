using OZTF.EducationManageSys.Domain.SeedWork;
using OZTF.EducationManageSys.Infrastructure.DataBase;
using System.Threading;
using System.Threading.Tasks;

namespace OZTF.EducationManageSys.Infrastructure.Domain
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly EducationContext _educationContext;

        public UnitOfWork(EducationContext educationContext)
        {
            _educationContext = educationContext;
        }

        public async Task<int> ComitAsync(CancellationToken cancellationToken)
        {
            return await _educationContext.SaveChangesAsync(cancellationToken);
        }
    }
}
