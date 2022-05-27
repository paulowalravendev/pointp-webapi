namespace PointPWebApi.Application.Services;

public class UserService : IUserService
{
    private readonly  IUserRepository _repository;
    private readonly IEncryptionService _encryptionService;

    public UserService(IUserRepository repository, IEncryptionService encryptionService)
    {
        _repository = repository;
        _encryptionService = encryptionService;
    }

    public async Task<UserEntity> CreateAdminUser(CreateAdminUserDto dto)
    {
        var userEntity = new UserEntity
        {
            Email = dto.Email,
            Name = dto.Name,
            EncryptedPassword = _encryptionService.EncryptPassword(dto.Password),
            Role = "Admin"
        };
        return await _repository.Create(userEntity);
    }

    public async Task<bool> IsEmailAvailable(string email) =>
        !await _repository.UserExistsByEmail(email);
}