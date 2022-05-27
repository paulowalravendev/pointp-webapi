namespace PointPWebApi.Infrastructure.StartupSetups;

public static class DbContextsSetup
{
    public static IServiceCollection AddDbContextsSetup(this IServiceCollection services,
        string sqlServerConnectionString)
        => services.AddSqlServer<PointPDebContext>(sqlServerConnectionString);
}