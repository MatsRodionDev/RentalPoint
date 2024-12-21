using FluentValidation;
using RentalPoint.Api.Dto;

namespace RentalPoint.Api.Validators
{
    public class RentalRequestValidator : AbstractValidator<RentalRequest>
    {
        public RentalRequestValidator()
        {
            RuleFor(r => r.ClientId).Cascade(CascadeMode.Stop)
               .NotNull().WithMessage("ClientId cannot be null");

            RuleFor(r => r.ItemId).Cascade(CascadeMode.Stop)
               .NotNull().WithMessage("ClientId cannot be null");
        }
    }
}
