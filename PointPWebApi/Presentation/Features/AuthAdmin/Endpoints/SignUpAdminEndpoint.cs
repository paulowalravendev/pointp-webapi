namespace PointPWebApi.Presentation.Features.AuthAdmin.Endpoints;

[Route(Routes.SignUpAdminUri)]
public class SignUpAdminEndpoint : EndpointBaseAsync.WithRequest<SignUpAdminRequest>
    .WithActionResult<SignUpAdminResponse>
{
    [HttpPost]
    [Consumes("application/json")]
    [Produces("application/json")]
    [SwaggerOperation(
        Summary = "SignUp Admin",
        Description = "SignUp for administrators",
        OperationId = nameof(SignUpAdminEndpoint),
        Tags = new[] { "AuthAdmin" })]
    [SwaggerResponse(StatusCodes.Status201Created, Type = typeof(SignUpAdminResponse))]
    [SwaggerResponse(StatusCodes.Status400BadRequest, Type = typeof(ErrorDefaultResponse))]
    public override Task<ActionResult<SignUpAdminResponse>> HandleAsync(SignUpAdminRequest request, 
        CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}