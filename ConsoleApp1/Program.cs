using System.Reflection.Metadata;
using System.Security.Principal;
using ConsoleApp1;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var shapes = new List<Shape>()
            {
                new Rectangle(10, 12),
                new Circle(3),
                new Rectangle(7, 5),
            };
            for (int i = 0; i < shapes.Count; i++)
            {
                Console.WriteLine(shapes[i]);
            }

            Console.WriteLine("Hello world!");
        }
    }
}