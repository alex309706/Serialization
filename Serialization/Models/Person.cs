using System;

namespace Serialization.Models
{
    [Serializable()]
    public class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
        [NonSerialized()] public string Patronymic;
    }
}
