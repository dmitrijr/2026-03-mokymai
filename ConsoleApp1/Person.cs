namespace HelloWorld
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

            Console.WriteLine("Person 1");
        }

        public Person(string firstName, string lastName, DateTime birthday)
            : this(lastName, birthday)
        {
            FirstName = firstName;

            Console.WriteLine("Person 2");
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
    }
}