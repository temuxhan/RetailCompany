using Store.Management.Service.Domain.Entities;

namespace Store.Management.Service.Domain.Interfaces.Database
{
    public interface IStoreRoomInventoryRepository
    {
        Task<Product> GetProduct(int id, int storeRoomId);
    }
}
