using FluentValidation;
using RentalPoint.Api.Dto;

namespace RentalPoint.Api.Validators
{
    public class ReviewRequestValidator : AbstractValidator<ReviewRequest>
    {
        public ReviewRequestValidator()
        {
            RuleFor(r => r.Rating).Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("Rating is required.")
                .Must(r => r <= 5).WithMessage("Rating cannot be greater than 5");

            RuleFor(r => r.ClientId).Cascade(CascadeMode.Stop)
               .NotNull().WithMessage("ClientId cannot be null");

            RuleFor(r => r.ItemId).Cascade(CascadeMode.Stop)
               .NotNull().WithMessage("ClientId cannot be null");
        }
    }
}
