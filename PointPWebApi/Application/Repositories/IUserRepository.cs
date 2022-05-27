namespace PointPWebApi.Application.Repositories;

public interface IUserRepository
{
    Task<UserEntity> Create(UserEntity userEntity);
    Task<bool> UserExistsByEmail(string email);
}