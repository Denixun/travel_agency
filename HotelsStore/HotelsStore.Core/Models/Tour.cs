using CSharpFunctionalExtensions;
using System.Text;

namespace HotelsStore.Core.Models
{
    public class Tour
    {
        private Tour(Guid id, string name, int numberOfTickets, decimal price, bool isActual, string description, string imageUrl, string countryCode, Guid hotelId)
        {
            Id = id;
            Name = name;
            NumberOfTickets = numberOfTickets;
            Price = price;
            IsActual = isActual;
            Description = description;
            ImageUrl = imageUrl;
            CountryCode = countryCode;
            HotelId = hotelId;
        }

        public Guid Id { get; private set; }
        public string Name { get; private set; } = string.Empty;
        public int NumberOfTickets { get; private set; } = 0;
        public decimal Price { get; private set; }
        public bool IsActual { get; private set; }
        public string? Description { get; private set; } = string.Empty;
        public string? ImageUrl { get; private set; } = string.Empty;
        public string CountryCode { get; private set; } = string.Empty;
        public Guid HotelId { get; private set; }
        public Country? Country { get; private set; }
        public List<Models.Type>? Types { get; private set; } = [];
        public Hotel? Hotel { get; private set; }
        public List<TourComment>? Comments { get; private set; } = [];

        public static Result<Tour> Create (Guid id, string name, int numberOfTickets, decimal price, bool isActual, string description, string imageUrl, string countryCode, Guid hotelId)
        {
            StringBuilder error = new StringBuilder();

            if (string.IsNullOrEmpty(name))
                error.AppendLine("Name is empty");

            if (numberOfTickets < 0)
                error.AppendLine("The number of tickets cannot be less than zero");

            if (price < 0)
                error.AppendLine("The price of tickets cannot be less than zero");

            if (countryCode.Length != 2)
                error.AppendLine("Incorrect country code");

            if (error.Length > 0)
                return Result.Failure<Tour>(error.ToString());

            Tour tour = new Tour(id, name, numberOfTickets, price, isActual, description, imageUrl, countryCode, hotelId);

            return Result.Success(tour);
        }
    }
}
