using Vehicles.Web.Entities;
using Microsoft.EntityFrameworkCore;

namespace Vehicles.Web.Data
{
    public class TestContext : DbContext
    {
        public TestContext(DbContextOptions options)
        : base(options)
        {}

        public DbSet<Vehicle> Vehicles { get; set; }

        public DbSet<Make> Makes { get; set; }

        public DbSet<Model> Models { get; set; }

        public DbSet<ModelYear> ModelYears { get; set; }

        public DbSet<Vin> Vins { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Make>().HasKey(t => t.MakeId);
            modelBuilder.Entity<Make>().Property(t => t.MakeId).ValueGeneratedOnAdd();

            modelBuilder.Entity<Model>().HasKey(t => t.ModelId);
            modelBuilder.Entity<Model>().Property(t => t.ModelId).ValueGeneratedOnAdd();
            modelBuilder.Entity<Model>().HasOne(t => t.Make);

            modelBuilder.Entity<ModelYear>().HasKey(t => new {t.ModelId, t.Year});

            modelBuilder.Entity<Vin>().HasKey(t => t.VehicleIdentificationNumber);

            modelBuilder.Entity<Vehicle>().HasKey(t => t.VehicleId);
            modelBuilder.Entity<Vehicle>().Property(t => t.VehicleId).ValueGeneratedOnAdd();
            modelBuilder.Entity<Vehicle>().HasOne(t => t.Model);
        }
    }
}
