using Data.Mappings;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class FleetDbContext : DbContext
    {
        public DbSet<Vehiculo> Vehiculos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer(@"Server=(localhost);Database=Fleet;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new VehiculoTypeConfiguration());
        }
    }
}
