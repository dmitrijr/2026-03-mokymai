namespace HelloWorld
{
    public class Student : Person
    {
        public string School { get; set; }

        public Student(string firstName, string lastName, DateTime birthday)
            : base(firstName, lastName, birthday)
        {
            Console.WriteLine("Creating Student");
        }
    }
}