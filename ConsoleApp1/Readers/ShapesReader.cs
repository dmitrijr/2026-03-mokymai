using ConsoleApp1.Exceptions;

namespace ConsoleApp1.Readers
{
    public class ShapesReader
    {
        public static Rectangle ReadRectangle()
        {
            try
            {
                Console.Write("Enter width: ");
                var width = Console.ReadLine();

                Console.Write("Enter height: ");
                var height = Console.ReadLine();

                return new Rectangle(double.Parse(width), double.Parse(height));
            }
            catch (NonPositiveValueException ex)
            {
                Console.WriteLine($"Ne teigiama reikšmė: {ex.Message}");

                throw;
            }
        }
    }
}