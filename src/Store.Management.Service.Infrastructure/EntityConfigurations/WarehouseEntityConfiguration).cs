using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Store.Management.Service.Domain.Entities;

namespace Store.Management.Service.Infrastructure.EntityConfigurations
{
    internal class WarehouseEntityConfiguration : IEntityTypeConfiguration<Warehouse>
    {
        public void Configure(EntityTypeBuilder<Warehouse> builder)
        {
        }
    }
}
