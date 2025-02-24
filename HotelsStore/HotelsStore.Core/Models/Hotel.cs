using CSharpFunctionalExtensions;
using System.Text;

namespace HotelsStore.Core.Models
{
    public class Hotel
    {
        public const int MIN_COUNT_OF_STARS = 1;
        public const int MAX_COUNT_OF_STARS = 5;
        private Hotel(Guid id, string name, int countOfStars, string decription)
        {
            Id = id;
            Name = name;
            CountOfStars = countOfStars;
            Description = decription;
        }

        public Guid Id { get; private set; }
        public string Name { get; private set; } = string.Empty;
        public int CountOfStars { get; private set; }
        public string? Description { get; private set; } = string.Empty;
        public List<Tour>? Tours { get; private set; } = [];

        public static Result<Hotel> Create(Guid id, string name, int countOfStars, string decription)
        {
            StringBuilder error = new StringBuilder();

            if (string.IsNullOrEmpty(name))
                error.AppendLine("Name is empty");

            if (countOfStars < MIN_COUNT_OF_STARS || countOfStars > MAX_COUNT_OF_STARS)
                error.AppendLine($"The number of stars is out of range ({MIN_COUNT_OF_STARS} - {MAX_COUNT_OF_STARS})");

            if (error.Length > 0)
                return Result.Failure<Hotel>(error.ToString());

            Hotel hotel = new Hotel(id, name, countOfStars, decription);

            return Result.Success(hotel);
        }
    }
}
