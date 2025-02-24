using HotelsStore.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelsStore.DataAccess.Configurations
{
    public class TourEntityConfiguration : IEntityTypeConfiguration<TourEntity>
    {
        public void Configure(EntityTypeBuilder<TourEntity> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(t => t.Country)
                .WithMany(c => c.Tours)
                .HasForeignKey(t => t.CountryCode);

            builder.HasMany(t => t.Types)
                .WithMany(c => c.Tours);

            builder.HasOne(t => t.Hotel)
                .WithMany(h => h.Tours)
                .HasForeignKey(t => t.HotelId);

            builder.HasMany(t => t.Comments)
                .WithOne(c => c.Tour);
        }
    }
}
