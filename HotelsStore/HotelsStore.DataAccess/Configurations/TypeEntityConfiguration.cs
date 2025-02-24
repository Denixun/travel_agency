using HotelsStore.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelsStore.DataAccess.Configurations
{
    public class TypeEntityConfiguration : IEntityTypeConfiguration<TypeEntity>
    {
        public void Configure(EntityTypeBuilder<TypeEntity> builder)
        {
            builder.HasKey(t => t.Id);

            builder.HasMany(t => t.Tours)
                .WithMany(t => t.Types);
        }
    }
}
