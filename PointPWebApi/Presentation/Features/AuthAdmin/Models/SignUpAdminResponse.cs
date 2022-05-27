namespace PointPWebApi.Presentation.Features.AuthAdmin.Models;

public class SignUpAdminResponse
{
    public SignUpAdminResponse(long id)
    {
        Id = id;
    }

    [SwaggerSchema(Description = "User identifier")]
    [SwaggerSchemaExample(1)]
    [Required]
    public long Id { get; init; }
}