using MediatR;

namespace OZTF.EducationManageSys.Application.Configuration.Queries
{
    public interface IQueryHandle<in TQuery, TResult>
        : IRequestHandler<TQuery, TResult> where TQuery : IQuery<TResult>
    {
    }
}
