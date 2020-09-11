using MediatR;

namespace OZTF.EducationManageSys.Application.Configuration.Commands
{
    public interface ICommandHandle<in TCommand>
        : IRequestHandler<TCommand> where TCommand : ICommand
    {
    }

    public interface ICommandHandle<in TCommand, TResult>
        : IRequestHandler<TCommand, TResult> where TCommand : ICommand<TResult>
    {

    }
}
