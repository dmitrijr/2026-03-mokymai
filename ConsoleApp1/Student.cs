namespace HelloWorld
{
    public class Student : Person
    {
        public string University { get; set; }

        public Student(string firstName, string lastName, DateTime birthday)
            : base(firstName, lastName, birthday)
        {
        }

        public override void Introduce()
        {
            Console.WriteLine($"I'm student. I'm studying at {University}");
        }
    }
}