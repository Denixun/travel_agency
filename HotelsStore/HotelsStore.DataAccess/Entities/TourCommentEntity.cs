namespace HotelsStore.DataAccess.Entities
{
    public class TourCommentEntity
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public Guid TourId { get; set; }
        public TourEntity? Tour { get; set; }
    }
}
