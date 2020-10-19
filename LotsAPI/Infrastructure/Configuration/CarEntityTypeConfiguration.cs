using Microsoft.EntityFrameworkCore;
using LotsAPI.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LotsAPI.Infrastructure.Configuration
{
    public class CarEntityTypeConfiguration : IEntityTypeConfiguration<CarModel>
    {
        public void Configure(EntityTypeBuilder<CarModel> builder)
        {
            builder.ToTable("car");

            builder.HasKey(p => p.IdCar);
            builder.Property(p => p.IdCar).HasColumnName("IdCar").IsRequired().ValueGeneratedOnAdd();
            builder.Property(p => p.Plate).HasColumnName("Plate").IsRequired().HasMaxLength(10);
        }
    }
}