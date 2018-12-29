using Microsoft.EntityFrameworkCore;
using TreeView_jQuery_AspNetCore_Mvc.Models;

namespace TreeView_jQuery_AspNetCore_Mvc.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<VehicleType>().HasData(
                new VehicleType() { Id = 1, Name = "Cars" },
                new VehicleType() { Id = 2, Name = "Bikes" });

            modelBuilder.Entity<VehicleSubType>().HasData(
                new VehicleSubType() { Id = 1, Name="Alto", VehicleTypeId = 1},
                new VehicleSubType() { Id = 2, Name = "WagonR", VehicleTypeId = 1 },
                new VehicleSubType() { Id = 3, Name = "Scorpio", VehicleTypeId = 1 },
                new VehicleSubType() { Id = 4, Name = "Duster", VehicleTypeId = 1 },
                new VehicleSubType() { Id = 5, Name = "Discover", VehicleTypeId = 2 },
                new VehicleSubType() { Id = 6, Name = "Avenger", VehicleTypeId = 2 },
                new VehicleSubType() { Id = 7, Name = "Unicorn", VehicleTypeId = 2 },
                new VehicleSubType() { Id = 8, Name = "Karizma", VehicleTypeId = 2 }
                );

        }
        public DbSet<VehicleSubType> VehicleSubTypes { get; set; }
        public DbSet<VehicleType> VehicleTypes { get; set; }
    }

}
