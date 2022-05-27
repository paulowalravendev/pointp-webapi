namespace PointPWebApi.Domain.Entities;

public class UserEntity : IEntity
{
    public long Id { get; set; }
    public string Name { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string? Role { get; set; }
    public string EncryptedPassword { get; set; } = null!;
}