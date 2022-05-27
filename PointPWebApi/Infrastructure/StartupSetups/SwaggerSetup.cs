namespace PointPWebApi.Infrastructure.StartupSetups;

public static class SwaggerSetup
{
    public static IServiceCollection AddSwaggerSetup(this IServiceCollection services)
        => services.AddSwaggerGen(setupAction =>
        {
            setupAction.SwaggerDoc(
                "PointPWebApiSpecification",
                new OpenApiInfo
                {
                    Title = "PointPWebApi",
                    Version = "1",
                    Description = "Description about PointPWebApiSpecification",
                    TermsOfService = new Uri("https://www.terms-of-services.com"),
                    License = new OpenApiLicense
                    {
                        Name = "License name",
                        Url = new Uri("https://www.license.com")
                    },
                    Contact = new OpenApiContact
                    {
                        Email = "owner@mail.com",
                        Name = "Owner name",
                        Url = new Uri("https://www.contact.com")
                    }
                });
            setupAction.EnableAnnotations();
            setupAction.SchemaFilter<SwaggerSchemaExampleFilter>();
        });
    
    public static IApplicationBuilder UseSwaggerSetup(this IApplicationBuilder app)
        => app.UseSwagger()
            .UseSwaggerUI(setupAction =>
            {
                setupAction.SwaggerEndpoint(
                    "/swagger/PointPWebApiSpecification/swagger.json",
                    "PointPWeb API");
                setupAction.RoutePrefix = "";
            });
}