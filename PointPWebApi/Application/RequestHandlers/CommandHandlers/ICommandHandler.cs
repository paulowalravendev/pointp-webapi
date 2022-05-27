namespace PointPWebApi.Application.RequestHandlers.CommandHandlers;

public interface ICommandHandler<in TRequest, TResponse> : IRequestHandler<TRequest, TResponse> where TRequest : 
    ICommand<TResponse>
{
}