namespace PointPWebApi.Shared.Requests.Commands;

public interface ICommand<out T> : IRequest<T>
{
}