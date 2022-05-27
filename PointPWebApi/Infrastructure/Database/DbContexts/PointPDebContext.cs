namespace PointPWebApi.Infrastructure.Database.DbContexts;

public class PointPDebContext : DbContext
{
    public DbSet<UserEntity> User { get; set; }
    
    public PointPDebContext(DbContextOptions<PointPDebContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<UserEntity>()
            .ToTable("Users");
        modelBuilder.Entity<UserEntity>()
            .Property(x => x.Email).IsRequired().HasMaxLength(255);
        modelBuilder.Entity<UserEntity>()
            .Property(x => x.Name).IsRequired().HasMaxLength(255);
        modelBuilder.Entity<UserEntity>()
            .Property(x => x.EncryptedPassword).IsRequired();
        modelBuilder.Entity<UserEntity>()
            .Property(x => x.Role).HasMaxLength(50);
        modelBuilder.Entity<UserEntity>().HasIndex(x => x.Email);
    }
}