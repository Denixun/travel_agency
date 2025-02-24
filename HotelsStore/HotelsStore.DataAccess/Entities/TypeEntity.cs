namespace HotelsStore.DataAccess.Entities
{
    public class TypeEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<TourEntity> Tours { get; set; } = [];
    }
}
