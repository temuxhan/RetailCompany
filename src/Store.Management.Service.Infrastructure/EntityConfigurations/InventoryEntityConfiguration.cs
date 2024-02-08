using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Store.Management.Service.Domain.Entities;

namespace Store.Management.Service.Infrastructure.EntityConfigurations
{
    internal class InventoryEntityConfiguration : IEntityTypeConfiguration<Inventory>
    {
        public void Configure(EntityTypeBuilder<Inventory> builder)
        {
        }
    }
}
