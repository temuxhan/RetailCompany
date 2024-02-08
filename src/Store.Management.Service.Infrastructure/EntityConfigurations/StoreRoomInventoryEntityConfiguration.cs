using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Store.Management.Service.Domain.Entities;

namespace Store.Management.Service.Infrastructure.EntityConfigurations
{
    internal class StoreRoomInventoryEntityConfiguration : IEntityTypeConfiguration<StoreRoomInventory>
    {
        public void Configure(EntityTypeBuilder<StoreRoomInventory> builder)
        {
        }
    }
}
