using System.Text.Json.Serialization;

namespace Serializer.Models
{
    public class Person
    {
        public int Id { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? FirstName { get; set; }

        [JsonPropertyName("surname")]
        public string? LastName { get; set; }

        public int Age { get; set; }

        [JsonIgnore]
        public bool IsAlive { get; set; }

        public Address? Address { get; set;}

        public IList<Phone>? Phones { get; set; }
    }
}