namespace PointPWebApi.Infrastructure.StartupSetups;

public static class FluentValidationSetup
{
    public static IServiceCollection AddFluentValidationWithSwaggerSetup(this IMvcBuilder mvcBuilder)
        => mvcBuilder.AddFluentValidation(options =>
        {
            options.ImplicitlyValidateChildProperties = true;
            options.ImplicitlyValidateRootCollectionElements = true;
            options.RegisterValidatorsFromAssembly(Assembly.GetExecutingAssembly());
        }).Services.AddFluentValidationRulesToSwagger(options =>
        {
            options.SetNotNullableIfMinLengthGreaterThenZero = true;
        });
    
}