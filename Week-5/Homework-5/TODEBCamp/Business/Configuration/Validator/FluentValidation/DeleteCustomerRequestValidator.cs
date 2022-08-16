using DTO.Customer;
using FluentValidation;

namespace Business.Configuration.Validator.FluentValidation
{
    public class DeleteCustomerRequestValidator : AbstractValidator<DeleteCustomerRequest>
    {
        public DeleteCustomerRequestValidator()
        {
            RuleFor(x => x.Id).GreaterThan(0).WithMessage("Id must greater than zero.");
        }
    }
}
