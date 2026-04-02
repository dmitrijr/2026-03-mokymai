using ConsoleApp1.Exceptions;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rectangle = new Rectangle(10, 4);

            StreamReader streamReader = null;
            try
            {
                Console.WriteLine("working 1...");

                using (streamReader = new StreamReader("data.txt"))
                {
                    rectangle.Width = -3;

                    Console.WriteLine("working 2...");
                }
            }
            catch (NonPositiveValueException ex)
            {
                Console.WriteLine($"Ne teigiama reikšmė: {ex.Message}");
            }
            finally
            {
                if (streamReader != null)
                    streamReader.Close();

                Console.WriteLine("Free resources...");
            }

            Console.WriteLine("End.");
        }
    }
}