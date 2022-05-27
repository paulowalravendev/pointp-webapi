namespace PointPWebApi.Domain.Services;

public interface IUserService
{
    Task<UserEntity> CreateAdminUser(CreateAdminUserDto dto);
    Task<bool> IsEmailAvailable(string email);
}

public record CreateAdminUserDto(string Name, string Email, string Password);