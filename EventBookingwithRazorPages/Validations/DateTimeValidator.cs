using EventBookingwithRazorPages.Models.ViewModels;
using FluentValidation;

namespace EventBookingwithRazorPages.Validations
{
    public class DateTimeValidator : AbstractValidator<AddEventViewModel>
    {

        public DateTimeValidator()
        {
            DateTime now = DateTime.Now;

            RuleFor(x => x.startDateTime)
                .LessThan(x => x.endDateTime)
                .WithMessage("Start must < End")
                .NotEmpty();

            RuleFor(x => x.endDateTime)
                .GreaterThan(x => x.startDateTime)
                .WithMessage("End must > Start")
                .NotEmpty();
        }
    }
}
