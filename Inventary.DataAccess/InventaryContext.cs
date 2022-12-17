using Inventary.Entities;
using Microsoft.EntityFrameworkCore;

namespace Inventary.DataAccess
{
    public class InventaryContext : DbContext
    {
        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<CategoryEntity> Category { get; set; }
        public DbSet<InOutEntity> InOut { get; set; }
        public DbSet<StorageEntity> Storage { get; set; }
        public DbSet<WarehouseEntity> Warehouse { get; set; }
    }
}