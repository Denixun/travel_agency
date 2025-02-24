using HotelsStore.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelsStore.DataAccess.Configurations
{
    public class HotelEntityConfiguration : IEntityTypeConfiguration<HotelEntity>
    {
        public void Configure(EntityTypeBuilder<HotelEntity> builder)
        {
            builder.HasKey(h => h.Id);

            builder.Property(h => h.Name)
                .IsRequired();

            builder.Property(h => h.CountOfStars)
                .IsRequired();

            builder.HasMany(h => h.Tours)
                .WithOne(t => t.Hotel);
        }
    }
}
