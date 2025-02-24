using System.Reflection;

namespace HotelsStore.DataAccess.Entities
{
    public class TourEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int NumberOfTickets { get; set; } = 0;
        public decimal Price { get; set; }
        public bool IsActual { get; set; }
        public string? Description { get; set; } = string.Empty;
        public string? ImageUrl { get; private set; } = string.Empty;
        public string CountryCode { get; set; } = string.Empty;
        public Guid HotelId { get; set; }
        public CountryEntity? Country { get; set; }
        public List<TypeEntity>? Types { get; set; } = [];
        public HotelEntity? Hotel { get; set; }
        public List<TourCommentEntity>? Comments { get; set; } = [];
    }
}
