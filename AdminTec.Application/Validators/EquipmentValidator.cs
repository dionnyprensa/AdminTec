using AdminTec.Domain.Entities;
using FluentValidation;

namespace AdminTec.Application.Validators
{
    public class EquipmentValidator : AbstractValidator<Equipment>
    {
        public EquipmentValidator()
        {
            RuleFor(e => e.SerialNumber)
                .NotEmpty().NotNull().WithMessage("Número de serie requerido.");

            RuleFor(e => e.TypeMachine)
                .IsInEnum().WithMessage("Información Inválida.");

            RuleFor(e => e.Model)
                .NotEmpty().NotNull().WithMessage("Modelo Requerido.");

            RuleFor(e => e.Location)
                .NotEmpty().NotNull().WithMessage("Ubicación Requerida.");

            RuleFor(e => e.IP)
                .NotEmpty().NotNull().WithMessage("{PropertyName} Requerida.")
                .Length(4, 12).WithMessage("{PropertyValue} no es una dirección IP válida.");

            RuleFor(e => e.CounterBnWCopies)
                .GreaterThanOrEqualTo(0).WithMessage("El valor debe ser mayor a cero (0).")
                .NotEmpty().NotNull().WithMessage("Valor requerido.");

            RuleFor(e => e.CounterBnWPrints)
                .GreaterThanOrEqualTo(0).WithMessage("El valor debe ser mayor a cero (0).")
                .NotEmpty().NotNull().WithMessage("Valor requerido.");

            RuleFor(e => e.CounterColorCopies)
                .GreaterThanOrEqualTo(0).WithMessage("El valor debe ser mayor a cero (0).")
                .NotEmpty().NotNull().WithMessage("Valor requerido.");

            RuleFor(e => e.CounterColorPrints)
                .GreaterThanOrEqualTo(0).WithMessage("El valor debe ser mayor a cero (0).")
                .NotEmpty().NotNull().WithMessage("Valor requerido.");
        }
    }
}