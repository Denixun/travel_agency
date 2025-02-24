using HotelsStore.Core.Models;
using HotelsStore.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelsStore.DataAccess.Configurations
{
    public class CountryEntityConfiguration : IEntityTypeConfiguration<CountryEntity>
    {
        public void Configure(EntityTypeBuilder<CountryEntity> builder)
        {
            builder.HasKey(c => c.Code);

            builder.Property(c => c.Code)
                .IsRequired()
                .HasMaxLength(Country.CODE_LENGTH);

            builder.HasMany(c => c.Tours)
                .WithOne(t => t.Country);
            
        }
    }
}
