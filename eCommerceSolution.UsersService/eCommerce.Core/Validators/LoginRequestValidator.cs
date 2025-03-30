using FluentValidation;
using eCommerce.Core.DTO;

namespace eCommerce.Core.Validators;
public class LoginRequestValidator : AbstractValidator<LoginRequest>
{
    public LoginRequestValidator()
    {
        //Email
        RuleFor(x => x.Email).NotEmpty().WithMessage("Email is required");
        RuleFor(x => x.Email).EmailAddress().WithMessage("Email is not valid, please provide the correct format");
        RuleFor(x => x.Password).NotEmpty().WithMessage("Password is required");
    }
}


