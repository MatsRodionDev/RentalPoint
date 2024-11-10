using FluentValidation;
using RentalPoint.Api.Dto;

namespace RentalPoint.Api.Validators
{
    public class ItemRequestValidator : AbstractValidator<ItemRequest>
    {
        public ItemRequestValidator()
        {
            RuleFor(p => p.Name).Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("Name is required.")
                .Must(n => n.Length >= 4).WithMessage("Name's length has to be at least 4")
                .Must(n => n.Length < 50).WithMessage("Name's length cannot exceed 50 characters");

            RuleFor(p => p.Price).Cascade(CascadeMode.Stop)
                .Must(n => n > 0).WithMessage("Price has to be greater than 0");
        }
    }
}
