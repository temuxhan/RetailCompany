using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Store.Management.Service.Infrastructure.EntityConfigurations
{
    internal class StoreEntityConfiguration : IEntityTypeConfiguration<Domain.Entities.Store>
    {
        public void Configure(EntityTypeBuilder<Domain.Entities.Store> builder)
        {
        }
    }
}
