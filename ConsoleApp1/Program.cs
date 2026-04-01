using ConsoleApp1.Exceptions;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rectangle = new Rectangle(10, 4);


            try
            {
                Console.WriteLine("working 1...");

                rectangle.Width = -3;

                Console.WriteLine("working 2...");
            }
            catch (NonPositiveValueException ex)
            {
                Console.WriteLine($"Ne teigiama reikšmė: {ex.Message}");
            }


            Console.WriteLine("Hello world!");
        }
    }
}