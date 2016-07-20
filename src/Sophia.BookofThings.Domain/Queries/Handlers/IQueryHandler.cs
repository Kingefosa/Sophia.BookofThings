namespace Sophia.BookofThings.Queries.Handlers
{
    internal interface IQueryHandler<in TQuery, out TResponse> 
        where TQuery : IQuery<TResponse>
    {
        TResponse Handle(TQuery query);
    }
}