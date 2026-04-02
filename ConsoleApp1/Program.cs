using ConsoleApp1.Exceptions;
using ConsoleApp1.Readers;

namespace ConsoleApp1
{
    internal class Program
    {
        static int Main(string[] args)
        {
            try
            {
                Console.WriteLine("working 1...");

                var ractangle = ShapesReader.ReadRectangle();

                Console.WriteLine("working 2...");
            }
            catch (BaseException ex)
            {
                Console.WriteLine("Validation/bad data error");
                return 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unhandled exception... Error message: {ex.Message}");
                Console.WriteLine(ex.StackTrace);
            }

            Console.WriteLine("End.");

            return 0;
        }
    }
}