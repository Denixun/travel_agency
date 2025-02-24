using CSharpFunctionalExtensions;
using System.Text;

namespace HotelsStore.Core.Models
{
    public class TourComment
    {
        private TourComment(Guid id, string title, string author, Guid tourId)
        {
            Id = id;
            Title = title;
            Author = author;
            TourId = tourId;
        }

        public Guid Id { get; private set; }
        public string Title { get; private set; } = string.Empty;
        public string Author { get; private set; } = string.Empty;
        public Guid TourId { get; private set; }
        public Tour? Tour { get; private set; }

        public static Result<TourComment> Create(Guid id, string title, string author, Guid tourId, Tour? tour)
        {
            StringBuilder error = new StringBuilder();

            if (string.IsNullOrEmpty(title))
                error.AppendLine("comment is empty");

            if (string.IsNullOrEmpty(author))
                error.AppendLine("author is empty");

            if (error.Length > 0)
                return Result.Failure<TourComment>(error.ToString());

            TourComment comment = new TourComment(id, title, author, tourId);

            return Result.Success(comment);
        }
    }
}
