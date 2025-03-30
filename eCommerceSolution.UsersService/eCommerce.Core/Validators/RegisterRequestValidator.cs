using FluentValidation;
using eCommerce.Core.DTO;
using System.Reflection;

namespace eCommerce.Core.Validators;
public class RegisterRequestValidator : AbstractValidator<RegisterRequest>
{
    public RegisterRequestValidator()
    {
        //Email
        RuleFor(x => x.Email).NotEmpty().WithMessage("Email is required");
        RuleFor(x => x.Email).EmailAddress().WithMessage("Email is not valid, please provide the correct format");
        //Password
        RuleFor(x => x.Password).NotEmpty().WithMessage("Password is required");
        //PersonName    
        RuleFor(x => x.PersonName).NotEmpty().WithMessage("Personal name is required");
        //Gender
        // Validate the Gender property. It is not necessary to validate the GenderOptions enum, as it is already validated by the EnumDataType attribute in the RegisterRequest class.
        RuleFor(request => request.Gender).IsInEnum().WithMessage("The 'gender' field must be one of the following valid values: Male, Female, Other.");

    }
}

