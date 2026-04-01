namespace ConsoleApp1
{
    public class Teacher : Person
    {
        public string Subject { get; set; }

        public Teacher(string lastName, DateTime birthday) : base(lastName, birthday)
        {

        }

        public new void Greet()
        {
            Console.WriteLine($"Hello, I am {Subject} Teacher");
        }
    }
}