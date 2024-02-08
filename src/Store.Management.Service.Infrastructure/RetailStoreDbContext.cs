using Microsoft.EntityFrameworkCore;
using Store.Management.Service.Domain.Entities;
using Store.Management.Service.Infrastructure.EntityConfigurations;

namespace Store.Management.Service.Infrastructure;

public class RetailStoreDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Domain.Entities.Store> Stores { get; set; }

    public DbSet<StoreRoomInventory> StoreRoomInventories { get; set; }

    public DbSet<Warehouse> Warehouses { get; set; }

    public RetailStoreDbContext(DbContextOptions<RetailStoreDbContext> options) : base(options)
    {
    }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new InventoryEntityConfiguration());
        modelBuilder.ApplyConfiguration(new ProductEntityConfiguration());
        modelBuilder.ApplyConfiguration(new StoreEntityConfiguration());
        modelBuilder.ApplyConfiguration(new StoreRoomEntityConfiguration());
        modelBuilder.ApplyConfiguration(new StoreRoomInventoryEntityConfiguration());
        modelBuilder.ApplyConfiguration(new WarehouseEntityConfiguration());

        modelBuilder.Entity<Product>().HasData(
            new Product { ProductID = 1, Name = "Laptop", Description = "High-performance laptop", Price = 1200.00M },
            new Product { ProductID = 2, Name = "Smartphone", Description = "Latest model smartphone", Price = 800.00M },
            new Product { ProductID = 3, Name = "Headphones", Description = "Noise-cancelling headphones", Price = 200.00M }
        );

        modelBuilder.Entity<Domain.Entities.Store>().HasData(
            new Domain.Entities.Store { StoreID = 1, Name = "Downtown Store", Address = "123 City Center Ave" }
        );

        modelBuilder.Entity<StoreRoomInventory>().HasData(
            new StoreRoomInventory { StoreRoomInventoryID = 1, ProductID = 1, Quantity = 1 },
            new StoreRoomInventory { StoreRoomInventoryID = 2, ProductID = 2, Quantity = 2 },
            new StoreRoomInventory { StoreRoomInventoryID = 3, ProductID = 3, Quantity = 3 }
        );
    }
}
