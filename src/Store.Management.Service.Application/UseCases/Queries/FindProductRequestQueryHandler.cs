using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using Store.Management.Service.Application.Dtos;
using Store.Management.Service.Domain.Interfaces.Database;

namespace Store.Management.Service.Application.UseCases.Queries
{
    internal class FindProductRequestQueryHandler : IRequestHandler<FindProductRequestQuery, ProductDto>
    {
        private readonly IStoreRoomInventoryRepository _storeRoomInventoryRepository;
        private readonly ILogger<FindProductRequestQueryHandler> _logger;
        private readonly IMapper _mapper;

        public FindProductRequestQueryHandler(IStoreRoomInventoryRepository storeRoomInventoryRepository,
            ILogger<FindProductRequestQueryHandler> logger,
            IMapper mapper)
        {
            _storeRoomInventoryRepository = storeRoomInventoryRepository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ProductDto> Handle(FindProductRequestQuery request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Trying to find product {productName} in local storage.", request.ProductName);

            Domain.Entities.Product? product = await _storeRoomInventoryRepository.GetProduct(request.ProductId, request.StoreId);

            if (product == null)
            {
                _logger.LogInformation("Trying to find product {productName} local warehouse.", request.ProductName);
                return null;
                // raise to update stock event
            }

            return _mapper.Map<ProductDto>(product);
        }
    }
}
