using System.Text.Json.Serialization;

namespace JsonSerializationAttributes.Models
{
    class Person
    {
        [JsonIgnore]
        public int Age { get; set; }
        [JsonPropertyName("Firstname")]

        public string Name { get; set; }

    }
}
