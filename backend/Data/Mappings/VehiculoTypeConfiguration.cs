using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Mappings
{
    internal class VehiculoTypeConfiguration : IEntityTypeConfiguration<Vehiculo>
    {
        public void Configure(EntityTypeBuilder<Vehiculo> builder)
        {
            builder
                .ToTable("Vehiculo");

            builder
                .HasKey(x => x.Identificador);

            builder
                .Property(x => x.Identificador)
                .UseIdentityColumn()
                .IsRequired();
            builder
                .Property(x => x.Marca)
                .HasField("_marca")
                .UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction)
                .HasMaxLength(100)
                .IsRequired();
            builder
                .Property(x => x.Modelo)
                .HasField("_modelo")
                .UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction)
                .HasMaxLength(100)
                .IsRequired();
            builder
                .Property(x => x.Ruedas)
                .HasField("_ruedas")
                .UsePropertyAccessMode(PropertyAccessMode.FieldDuringConstruction)
                .HasMaxLength(100)
                .IsRequired();
            builder
                .Property(x => x.NumeroChasis);
            builder
                .Property(x => x.KilometrosRecorridos);
        }
    }
}
