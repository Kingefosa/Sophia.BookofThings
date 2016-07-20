namespace Sophia.BookofThings
{
    using Queries;

    public interface IMessageBus
    {
        void Handle<TCommand>(TCommand command);

        TResponse Handle<TResponse>(IQuery<TResponse> query);
    }
}