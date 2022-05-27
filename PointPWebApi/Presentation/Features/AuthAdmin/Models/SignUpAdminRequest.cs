namespace PointPWebApi.Presentation.Features.AuthAdmin.Models;

public class SignUpAdminRequest
{
    [SwaggerSchema(Description = "Administrator name")]
    [SwaggerSchemaExample("Paulo Marcelo")]
    public string Name { get; init; } = null!;
    [SwaggerSchema(Description = "Administrator e-mail")]
    [SwaggerSchemaExample("paulo@mail.com")]
    public string Email { get; init; } = null!;
    [SwaggerSchema(Description = "Administrator password")]
    [SwaggerSchemaExample("StrongPassword@123321")]
    public string Password { get; init; } = null!;
}