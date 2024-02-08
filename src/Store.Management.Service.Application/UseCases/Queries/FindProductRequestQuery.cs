using MediatR;
using Store.Management.Service.Application.Dtos;

namespace Store.Management.Service.Application.UseCases.Queries
{
    public class FindProductRequestQuery : IRequest<ProductDto>
    {
        public int ProductId { get; set; }
        public int StoreId { get; set; }
        public int WarehouseId { get; set; }

        public string ProductName { get; set; }
    }
}
