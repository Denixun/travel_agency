namespace HotelsStore.DataAccess.Entities
{
    public class HotelEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int CountOfStars { get; set; }
        public string? Description { get; set; } = string.Empty;
        public List<TourEntity>? Tours { get; set; } = [];
    }
}
