namespace PointPWebApi.Shared.Requests.Commands;

public record CreateUserAdminCommand(string Name, string Email, string Password) : ICommand<Result<long>>;