using AdminTec.Domain.Entities;
using FluentValidation;

namespace AdminTec.Application.Validators
{
    public class RequestValidator : AbstractValidator<Request>
    {
        public RequestValidator()
        {
            RuleFor(e => e.Quantity)
                .GreaterThan(0).WithMessage("La Cantidad debe ser mayor a 0.")
                .NotNull().WithMessage("Cantidad requerida.")
                .NotEmpty().WithMessage("Cantidad requerida.");

            RuleFor(e => e.EmailTo)
                .Matches(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$").WithMessage("Correo inválido")
                .NotNull().WithMessage("Correo requerido.")
                .NotEmpty().WithMessage("Correo Requerido.");
        }
    }
}