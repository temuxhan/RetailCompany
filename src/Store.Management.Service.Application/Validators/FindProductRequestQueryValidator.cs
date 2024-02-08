using FluentValidation;
using Store.Management.Service.Application.UseCases.Queries;

namespace Store.Management.Service.Application.Validators
{
    public class FindProductRequestQueryValidator : AbstractValidator<FindProductRequestQuery>
    {
        public FindProductRequestQueryValidator()
        {

            RuleFor(x => x.ProductName)
                .NotEmpty();

            RuleFor(x => x.WarehouseId)
                .GreaterThan(0);

            RuleFor(x => x.ProductId)
               .GreaterThan(0);

            RuleFor(x => x.StoreId)
              .GreaterThan(0);
        }
    }
}
