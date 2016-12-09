using AdminTec.Domain.Entities;
using FluentValidation;

namespace AdminTec.Application.Validators
{
    public class TonerValidator : AbstractValidator<Toner>
    {
        public TonerValidator()
        {
            RuleFor(t => t.Code)
                .Matches(@"/[a-zA-Z0-9]+/g").WithMessage("Solo letras y números.")
                .NotNull().WithMessage("Código requerido.")
                .NotEmpty().WithMessage("Código requerido.");

            RuleFor(t => t.Target)
                .GreaterThan(0).WithMessage("El Objetivo debe ser mayor a 0.")
                .NotNull().WithMessage("Objetivo requerido.")
                .NotEmpty().WithMessage("Objetivo requerido.");

            RuleFor(t => t.TonerType)
                .IsInEnum().WithMessage("Información Inválida.");
        }
    }
}