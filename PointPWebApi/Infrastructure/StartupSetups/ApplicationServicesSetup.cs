namespace PointPWebApi.Infrastructure.StartupSetups;

public static class ApplicationServicesSetup
{
    public static IServiceCollection AddApplicationServicesSetup(this IServiceCollection services)
        => services.AddScoped<IUserService, UserService>()
            .AddScoped<IEncryptionService, EncryptionService>();
}

public static class ApplicationRepositoriesSetup
{
    public static IServiceCollection AddApplicationRepositoriesSetup(this IServiceCollection services)
        => services.AddScoped<IUserRepository, UserRepository>();
}