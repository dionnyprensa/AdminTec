using AdminTec.Domain.Entities;
using FluentValidation;

namespace AdminTec.Application.Validators
{
    public class VisitValidator : AbstractValidator<Visit>
    {
        public VisitValidator()
        {
            RuleFor(v => v.VisitType)
                .IsInEnum().WithMessage("Información Invalida");

            RuleFor(v => v.EquipmentId)
                .GreaterThan(0)
                .NotNull().NotEmpty().WithMessage("Específique un Equipo");

            RuleFor(v => v.TechnicianId)
                .GreaterThan(0)
                .NotNull().NotEmpty().WithMessage("Específique un Técnico");
        }
    }
}