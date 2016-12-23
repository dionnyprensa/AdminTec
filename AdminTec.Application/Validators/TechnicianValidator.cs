using AdminTec.Domain.Entities;
using FluentValidation;

namespace AdminTec.Application.Validators
{
    public class TechnicianValidator : AbstractValidator<Technician>
    {
        public TechnicianValidator()
        {
            RuleFor(u => u.FirstName)
                .Matches(@"^[a-zA-Z ]+\w$").WithMessage("Solo letras.")
                .NotNull().WithMessage("Requerido.")
                .NotEmpty().WithMessage("Requerido.")
                .Length(min: 4, max: 32).WithMessage("Debe tener entre 4 y 32 letras.");

            RuleFor(u => u.LastName)
                .Matches(@"^[a-zA-Z ]+\w$").WithMessage("Solo letras.")
                .NotNull().WithMessage("Requerido.")
                .NotEmpty().WithMessage("Requerido.")
                .Length(min: 4, max: 64).WithMessage("Debe tener entre 4 y 64 letras.");
        }
    }
}