using FluentValidation;
using RentalPoint.Api.Dto;

namespace RentalPoint.Api.Validators
{
    public class EventRequestValidator : AbstractValidator<EventRequest>
    {
        public EventRequestValidator()
        {
            RuleFor(e => e.StartDate)
            .GreaterThan(DateTime.Now).WithMessage("Start date must be in the future.");

            RuleFor(e => e.EndDate)
                .GreaterThan(DateTime.Now).WithMessage("Start date must be in the future.")
                .GreaterThan(e => e.StartDate).WithMessage("End date must be greater than start date.");
        }
    }
}
