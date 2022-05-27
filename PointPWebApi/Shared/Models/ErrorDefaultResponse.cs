namespace PointPWebApi.Shared.Models;

public class ErrorDefaultResponse
{
    [SwaggerSchema(Description = "Error message")]
    [SwaggerSchemaExample("Field is invalid")]
    [Required]
    public string Message { get; init; }
    [SwaggerSchema(Description = "Error code")]
    [SwaggerSchemaExample("INVALID_FIELD")]
    [Required]
    public string Code { get; init; }
}