using Employee.API.Models;
using FluentValidation;

namespace Employee.API.Validators
{
    public class EmployeeValidator : AbstractValidator<EmployeeRequest>
    {
        public EmployeeValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Name cannot be empty!");

            RuleFor(x => x.Gender)
                .IsInEnum()
                .NotNull().WithMessage("Gender cannot be empty!");

            RuleFor(x => x.Age)
                .NotEmpty().WithMessage("Age cannot be empty!")
                .GreaterThan(0).WithMessage("Age should be greater than zero.");

            RuleFor(x => x.Activity)
                .NotEmpty().WithMessage("Activity cannot be empty!");
        }
    }
}