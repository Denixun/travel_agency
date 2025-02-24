using HotelsStore.DataAccess.Configurations;
using Microsoft.EntityFrameworkCore;

namespace HotelsStore.DataAccess.Entities
{
    public class ToursDBContext: DbContext
    {
        public ToursDBContext(DbContextOptions<ToursDBContext> options) : base(options) { }

        public DbSet<CountryEntity> Countries { get; set; }
        public DbSet<HotelEntity> Hotel { get; set; }
        public DbSet<TourCommentEntity> TourComments { get; set; }
        public DbSet<TourEntity> Tours { get; set; }
        public DbSet<TypeEntity> Types { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new CountryEntityConfiguration());
            builder.ApplyConfiguration(new HotelEntityConfiguration());
            builder.ApplyConfiguration(new TourCommentEntityConfiguration());
            builder.ApplyConfiguration(new TourEntityConfiguration());
            builder.ApplyConfiguration(new TypeEntityConfiguration());
        }
    }
}
