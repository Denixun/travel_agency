using System.Text;
using CSharpFunctionalExtensions;

namespace HotelsStore.Core.Models
{
    public class Country
    {
        public const int CODE_LENGTH = 2;
        public const int MAX_NAME_LENGTH = 250;

        private Country(string code, string name)
        {
            Code = code;
            Name = name;
        }

        public string Code { get; private set; } = string.Empty;
        public string Name { get; private set; } = string.Empty;
        public List<Tour>? Tours { get; private set; }

        public static Result<Country> Create(string code, string name)
        {
            StringBuilder error = new StringBuilder();

            if (string.IsNullOrEmpty(code) || code.Length != CODE_LENGTH)
                error.AppendLine("Incorrect country code entered");

            if (string.IsNullOrEmpty(name) || name.Length > MAX_NAME_LENGTH)
                error.AppendLine($"Country name empty or over {MAX_NAME_LENGTH} symbols");

            if (error.Length > 0)
                return Result.Failure<Country>(error.ToString());

            var country = new Country(code, name);

            return Result.Success(country);
        }
    }
}
