using AdminTec.Domain.Entities;
using FluentValidation;

namespace AdminTec.Application.Validators
{
    public class PartValidator : AbstractValidator<Part>
    {
        public PartValidator()
        {
            RuleFor(e => e.Code)
                .NotNull().WithMessage("Código requerido.")
                .NotEmpty().WithMessage("Código requerido.")
                .Length(min: 4, max: 16).WithMessage("El Código debe tener entre 4 y 16 letras.");

            RuleFor(e => e.Name)
                .Matches(@"/[a-zA-Z ]+\w/g").WithMessage("Sólo se permiten letras.")
                .NotNull().WithMessage("Nombre requerido.")
                .NotEmpty().WithMessage("Nombre Requerido.")
                .Length(min: 4, max: 32).WithMessage("El Nombre debe tener entre 4 y 32 letras.");

            RuleFor(e => e.Description)
                .NotNull().WithMessage("Descripción Requerido.")
                .NotEmpty().WithMessage("Descripción Requerido.")
                .Length(min: 0, max: 128).WithMessage("Máximo 128 carácteres.");

            RuleFor(e => e.Target)
                .GreaterThan(0).WithMessage("El Objetivo debe ser mayor a 0.")
                .NotNull().WithMessage("Objetivo requerido.")
                .NotEmpty().WithMessage("Objetivo requerido.");
        }
    }
}