using System;
using DTO.User;

using FluentValidation;

namespace Business.Configuration.Validator.FluentValidation
{
    public class CreateUserRegisterRequestValidator : AbstractValidator<CreateUserRegisterRequest>
    {
        public CreateUserRegisterRequestValidator()
        {
            // Validation kontrollerimizin kurallarını bu bölümde belirtiyoruz.
            RuleFor(x => x.Name).NotEmpty().WithMessage("FirstName can't be empty.");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("SurName can't be empty");
            RuleFor(x => x.Address).NotEmpty().WithMessage("Address can't be empty");
            RuleFor(x => x.City).NotEmpty().WithMessage("City can't be empty");
            RuleFor(x => x.Email).EmailAddress();
            RuleFor(x => x.PhoneNumber).NotEmpty().WithMessage("City can't be empty");
            RuleFor(x => x.UserPassword).Equal(x => x.ConfirmPassword).WithMessage("Confirm Password can't be different to password..");
        }
    }
}
