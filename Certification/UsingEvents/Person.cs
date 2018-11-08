using System;

namespace UsingEvents
{
    // Create a class Person which has a property “Name”. 
    // Your task is to invoke an event that checks if a person’s
    // name has changed or not and assign a new value to a person name.
    public class Person
    {
        public event Predicate<string> IsChanged;
        private readonly string name;
        public Person(string name)
        {
            this.name = name;
        }
        public string Name
        {
            get => name;
            set
            {
                if (value == null) throw new ArgumentNullException(nameof(value));
                bool? t = IsChanged?.Invoke(value);
                Console.WriteLine(t?.ToString());
            }
        }
    }
}
