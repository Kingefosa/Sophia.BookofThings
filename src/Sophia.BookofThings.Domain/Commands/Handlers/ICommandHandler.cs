namespace Sophia.BookofThings.Commands.Handlers
{
    internal interface ICommandHandler<in TCommand> 
        where TCommand : ICommand
    {
        void Handle(TCommand command);
    }
}