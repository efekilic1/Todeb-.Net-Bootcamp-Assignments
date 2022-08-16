using DTO.Customer;
using FluentValidation;

namespace Businnes.Configuration.Validator.FluentValidation
{
    public class CreateCustomerRequestValidator : AbstractValidator<CreateCustomerRequest>
    {
        public CreateCustomerRequestValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("FirstName can't be empty.");
            RuleFor(x => x.LastName).NotEmpty().WithMessage("SurName can't be empty");
            RuleFor(x => x.PhoneNumber).NotEmpty().WithMessage("PhoneNumber can't be empty.");
            RuleFor(x => x.Email).NotEmpty().EmailAddress().WithMessage("Please enter a valid email address.");
        }




    }
}
