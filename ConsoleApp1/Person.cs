namespace HelloWorld
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person()
        {
            Console.WriteLine("Creating Person");
        }

        public void Greet()
        {
            Console.WriteLine($"Hello, my name is {FirstName}");
        }
    }
}