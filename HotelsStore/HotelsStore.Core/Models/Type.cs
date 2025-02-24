using CSharpFunctionalExtensions;
using System.Text;

namespace HotelsStore.Core.Models
{
    public class Type
    {
        private Type(Guid id, string name)
        {
            Id = id;
            Name = name;
        }

        public Guid Id { get; private set; }
        public string Name { get; private set; } = string.Empty;
        public List<Tour> Tours { get; private set; } = [];

        public static Result<Type> Create(Guid id, string name)
        {
            StringBuilder error = new StringBuilder();

            if (string.IsNullOrEmpty(name))
                error.AppendLine("name is empty");

            if (error.Length > 0)
                return Result.Failure<Type>(error.ToString());

            Type type = new Type(id, name);

            return Result.Success(type);
        }
    }
}
