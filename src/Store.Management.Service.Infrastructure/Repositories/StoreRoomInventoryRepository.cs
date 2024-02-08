using Microsoft.EntityFrameworkCore;
using Store.Management.Service.Domain.Entities;
using Store.Management.Service.Domain.Interfaces.Database;

namespace Store.Management.Service.Infrastructure.Repositories
{
    public class StoreRoomInventoryRepository : IStoreRoomInventoryRepository
    {
        private readonly RetailStoreDbContext _retailStoreDbContext;

        public StoreRoomInventoryRepository(RetailStoreDbContext retailStoreDbContext)
        {
            _retailStoreDbContext = retailStoreDbContext;
        }
        public async Task<Product> GetProduct(int id, int storeRoomId)
        {
            return await _retailStoreDbContext.StoreRoomInventories
                .Include(sr => sr.Product)
                .Where(sr => sr.ProductID == id
                && sr.Quantity > 0
                && sr.StoreRoomID == storeRoomId)
                .Select(sr => sr.Product)
                .FirstOrDefaultAsync();
        }
    }
}
