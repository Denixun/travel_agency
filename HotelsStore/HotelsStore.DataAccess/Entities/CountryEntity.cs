
namespace HotelsStore.DataAccess.Entities
{
    public class CountryEntity
    {
        public string Code { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public List<TourEntity>? Tours { get; private set; }
    }
}
