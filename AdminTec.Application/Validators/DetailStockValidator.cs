using AdminTec.Domain.Entities;
using FluentValidation;

namespace AdminTec.Application.Validators
{
    public class DetailStockValidator : AbstractValidator<DetailStock>
    {
        public DetailStockValidator()
        {
            RuleFor(ds => ds.Quantity)
                .NotEmpty().NotNull().WithMessage("Cantidad requerida.")
                .GreaterThan(0).WithMessage("La cantidad debe ser mayor que cero (0)");

            RuleFor(ds => ds.DateOfEntry)
                .NotEmpty().NotNull().WithMessage("Fecha de entrada requerida.");
        }
    }
}