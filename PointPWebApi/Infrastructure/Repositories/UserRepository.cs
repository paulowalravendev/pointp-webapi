
namespace PointPWebApi.Infrastructure.Repositories;

public class UserRepository : IUserRepository
{
    private readonly PointPDebContext _context;

    public UserRepository(PointPDebContext context) => 
        _context = context;

    public async Task<UserEntity> Create(UserEntity userEntity)
    {
        await _context.AddAsync(userEntity);
        await _context.SaveChangesAsync();
        return userEntity;
    }

    public async Task<bool> UserExistsByEmail(string email) => 
        await _context.User.AsNoTracking().AnyAsync(u => u.Email == email);
}