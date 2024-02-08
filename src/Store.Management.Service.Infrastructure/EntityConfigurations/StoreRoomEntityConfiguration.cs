using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Store.Management.Service.Domain.Entities;

namespace Store.Management.Service.Infrastructure.EntityConfigurations
{
    internal class StoreRoomEntityConfiguration : IEntityTypeConfiguration<StoreRoom>
    {
        public void Configure(EntityTypeBuilder<StoreRoom> builder)
        {
        }
    }
}
