using PointPWebApi.Shared.Requests.Commands;

namespace PointPWebApi.Presentation.Features.AuthAdmin.Endpoints;

[Route(Routes.SignUpAdminUri)]
public class SignUpAdminEndpoint : EndpointBaseAsync.WithRequest<SignUpAdminRequest>
    .WithActionResult<SignUpAdminResponse>
{
    private readonly ISender _sender;

    public SignUpAdminEndpoint(ISender sender) => 
        _sender = sender;

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
    public override async Task<ActionResult<SignUpAdminResponse>> HandleAsync(SignUpAdminRequest request, 
        CancellationToken cancellationToken = default)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState.Values);
        var result = await _sender.Send(
            new CreateUserAdminCommand(request.Name, request.Email, request.Password),
            cancellationToken);
        if (!result.IsSuccess)
            return BadRequest(result.Exception);
        return StatusCode(StatusCodes.Status201Created, new SignUpAdminResponse(result.Value));
    }
}