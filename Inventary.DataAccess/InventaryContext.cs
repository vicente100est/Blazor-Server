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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost; Database=InventaryDb; Trusted_Connection=True; Encrypt=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder mBuilder)
        {
            base.OnModelCreating(mBuilder);
            mBuilder.Entity<CategoryEntity>().HasData(
                new CategoryEntity { CategoryId = "ASH", CategoryName = "Aseo Hogar" },
                new CategoryEntity { CategoryId = "ASP", CategoryName = "Aseo Personal" },
                new CategoryEntity { CategoryId = "HGR", CategoryName = "Hogar" },
                new CategoryEntity { CategoryId = "PRF", CategoryName = "Perfumeria" },
                new CategoryEntity { CategoryId = "SLD", CategoryName = "Salud" },
                new CategoryEntity { CategoryId = "VDJ", CategoryName = "Video Juegos" }
                );
            mBuilder.Entity<WarehouseEntity>().HasData(
                new WarehouseEntity
                {
                    WarehouseId = Guid.NewGuid().ToString(),
                    WarehouseName = "Mexico Center",
                    WarehouseAddress = "Av. Paseo de la Reforma 326, Juárez, Cuauhtémoc, 06600 Ciudad de México, CDMX"
                },
                new WarehouseEntity
                {
                    WarehouseId = Guid.NewGuid().ToString(),
                    WarehouseName = "USA Cebter",
                    WarehouseAddress = "2375 Pennsylvania Av. NW, 20037 Washington DC."
                },
                new WarehouseEntity
                {
                    WarehouseId = Guid.NewGuid().ToString(),
                    WarehouseName = "Canada Center",
                    WarehouseAddress = "74 Stanley Avenue. Ottawa (Ontario), K1M 1P4."
                }
                );
        }
    }
}