namespace ConsoleApp1
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Country { get; set; }
        public DateTime Birthday { get; set; }

        public Person(string lastName, DateTime birthday)
        {
            LastName = lastName;
            Birthday = birthday;
        }

        public Person(string firstName, string lastName, DateTime birthday)
            : this(lastName, birthday)
        {
            FirstName = firstName;
        }

        public Person(string firstName, string lastName, string country, DateTime birthday)
            : this(firstName, lastName, birthday)
        {
            Country = country;
        }

        public void Greet()
        {
            Console.WriteLine($"Hello, my name is {FirstName} {LastName}");
        }

        public virtual void Introduce()
        {
            Console.WriteLine("I'm person");
        }
    }
}