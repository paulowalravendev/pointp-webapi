namespace PointPWebApi.Presentation.Features.AuthAdmin.Models;

public class SignUpAdminResponse
{
    [SwaggerSchema(Description = "User identifier")]
    [SwaggerSchemaExample(1)]
    [Required]
    public long Id { get; init; }
}