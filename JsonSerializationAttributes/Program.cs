using JsonSerializationAttributes.Models;
using System;
using System.Text.Json;

namespace JsonSerializationAttributes
{
    class Program
    {
        static void Main(string[] args)
        {
            JsonSerializerOptions options = new JsonSerializerOptions()
            { 
                WriteIndented=true
            };
            Person Alex = new Person() { Name = "Alex", Age = 24 };
            string objectToJson = JsonSerializer.Serialize(Alex,options);
            Console.WriteLine(objectToJson);

            Person DeserealizedObject = JsonSerializer.Deserialize<Person>(objectToJson);
            Console.WriteLine($"Name = {DeserealizedObject.Name} Age = {DeserealizedObject.Age}");


        }
    }
}
