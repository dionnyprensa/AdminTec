using AdminTec.Domain.Entities;
using FluentValidation;

namespace AdminTec.Application.Validators
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u => u.UserName)
                .Matches(@"/[a-zA-Z]+\w/g").WithMessage("Solo letras.")
                .NotNull().WithMessage("Requerido.")
                .NotEmpty().WithMessage("Requerido.")
                .Length(min: 4, max: 16).WithMessage("Debe tener entre 4 y 16 letras.");

            RuleFor(u => u.Password)
                .Matches(@"/^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,16}$/g").WithMessage("Debe tener entre 8 y 16 letras. Al menos 1 Mayúscula y 1 Número.")
                .NotNull().WithMessage("Requerido.")
                .NotEmpty().WithMessage("Requerido.");

            RuleFor(u => u.FirstName)
                .Matches(@"/[a-zA-Z ]+\w/g").WithMessage("Solo letras.")
                .NotNull().WithMessage("Requerido.")
                .NotEmpty().WithMessage("Requerido.")
                .Length(min: 4, max: 32).WithMessage("Debe tener entre 4 y 32 letras.");

            RuleFor(u => u.LastName)
                .Matches(@"/[a-zA-Z ]+\w/g").WithMessage("Solo letras.")
                .NotNull().WithMessage("Requerido.")
                .NotEmpty().WithMessage("Requerido.")
                .Length(min: 4, max: 64).WithMessage("Debe tener entre 4 y 64 letras.");
        }
    }
}