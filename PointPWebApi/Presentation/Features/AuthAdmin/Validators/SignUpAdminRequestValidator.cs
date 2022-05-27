
namespace PointPWebApi.Presentation.Features.AuthAdmin.Validators;

public class SignUpAdminRequestValidator : AbstractValidator<SignUpAdminRequest>
{
    public SignUpAdminRequestValidator()
    {
        RuleFor(x => x.Email).EmailAddress().NotEmpty().MaximumLength(255);
        RuleFor(x => x.Name).NotEmpty().MinimumLength(3).MaximumLength(255);
        RuleFor(x => x.Password).NotEmpty().MinimumLength(8).MaximumLength(255);
    }
}