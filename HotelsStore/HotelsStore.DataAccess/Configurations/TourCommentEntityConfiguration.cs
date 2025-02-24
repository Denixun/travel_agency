using HotelsStore.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelsStore.DataAccess.Configurations
{
    public class TourCommentEntityConfiguration : IEntityTypeConfiguration<TourCommentEntity>
    {
        public void Configure(EntityTypeBuilder<TourCommentEntity> builder)
        {
            builder.HasKey(c => c.Id);

            builder.HasOne(c => c.Tour)
                .WithMany(t => t.Comments)
                .HasForeignKey(c => c.TourId);

        }
    }
}
