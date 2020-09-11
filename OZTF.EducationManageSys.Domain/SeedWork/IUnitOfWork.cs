using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OZTF.EducationManageSys.Domain.SeedWork
{
    public interface IUnitOfWork
    {
        Task<int> ComitAsync(CancellationToken cancellationToken);
    }
}
