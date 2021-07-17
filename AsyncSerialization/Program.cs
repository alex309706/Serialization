using System;
using Serialization.Models;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace AsyncSerialization
{
    class Program
    {
        static async Task Main(string[] args)
        {
            try
            {
                using (FileStream fs = new FileStream("test.txt", FileMode.OpenOrCreate))
                {
                    Person Alex = new Person() { Name = "Alex", Age = 24, Patronymic = "Test" };
                    JsonSerializerOptions options = new JsonSerializerOptions()
                    {
                        WriteIndented = true
                    };
                    await JsonSerializer.SerializeAsync(fs, Alex,options);
                    Console.WriteLine("Serialize was successful!");
                }

                using (FileStream fs = new FileStream("test.txt", FileMode.OpenOrCreate))
                {
                  
                    Person person =  await JsonSerializer.DeserializeAsync<Person>(fs);
                    Console.WriteLine("Deserialization was successful!");

                    Console.WriteLine(person.Age);
                    Console.WriteLine(person.Name);
                    
                }

            }
            catch (Exception)
            {

                Console.WriteLine("Something bad happend!");
            }
           


        }
    }
}
