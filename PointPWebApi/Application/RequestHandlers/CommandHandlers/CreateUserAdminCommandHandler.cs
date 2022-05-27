using PointPWebApi.Application.Exceptions;

namespace PointPWebApi.Application.RequestHandlers.CommandHandlers;

public class CreateUserAdminCommandHandler : ICommandHandler<CreateUserAdminCommand, Result<long>>
{
    private readonly IUserService _userService;

    public CreateUserAdminCommandHandler(IUserService userService)
    {
        _userService = userService;
    }

    public async Task<Result<long>> Handle(CreateUserAdminCommand request, CancellationToken cancellationToken)
    {
        if (!await _userService.IsEmailAvailable(request.Email))
            return new UserEmailUnavailableException(request.Email);
        var user =
            await _userService.CreateAdminUser(new CreateAdminUserDto(request.Name, request.Email, request.Password));
        return user.Id;
    }
}