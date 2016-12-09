using AdminTec.Domain.Entities;
using FluentValidation;

namespace AdminTec.Application.Validators
{
    public class DetailVisitValidator : AbstractValidator<DetailVisit>
    {
        public DetailVisitValidator()
        {
            RuleFor(dv => dv.Comments)
                .Length(0, 128).WithMessage("Maximo 128 carácteres.");
        }
    }
}