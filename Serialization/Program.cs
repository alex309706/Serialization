using Serialization.Models;
using System;
using System.Text.Json;

namespace Serialization
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Alex = new Person() {Name ="Alex", Age = 24,Patronymic="Test" };
            string objectToJson = JsonSerializer.Serialize<Person>(Alex);
            Console.WriteLine(objectToJson);

            Person deserealizedObject = JsonSerializer.Deserialize<Person>(objectToJson);
            string name = deserealizedObject.Name;

            int age = deserealizedObject.Age;

            string patronymic = deserealizedObject.Patronymic;

            Console.WriteLine(name);
            Console.WriteLine(age);
            Console.WriteLine(patronymic);

        }
    }
  
}
