using AdminTec.Domain.Entities;
using FluentValidation;

namespace AdminTec.Application.Validators
{
    public class StockValidator : AbstractValidator<Stock>
    {
        public StockValidator()
        {
            RuleFor(s => s.EquipmentId)
                .GreaterThan(0).When(x => x.PartId == 0 || x.TonerId == 0)
                .WithMessage("Debe selecionar un Equipo valido.");

            RuleFor(s => s.PartId)
                .GreaterThan(0).When(x => x.TonerId == 0 || x.EquipmentId == 0)
                .WithMessage("Debe selecionar una Parte valida.");

            RuleFor(s => s.TonerId)
                .GreaterThan(0).When(x => x.EquipmentId == 0 || x.PartId == 0)
                .WithMessage("Debe selecionar un Toner valido.");
        }
    }
}