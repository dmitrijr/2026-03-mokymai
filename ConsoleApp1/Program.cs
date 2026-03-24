namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rect3 = new Rectangle(7, 4);
            var rect1 = new Rectangle(10.2, 5.7);
            var rect2 = new Rectangle(3, 8);

            Console.WriteLine($"Rectangle: {rect1.GetArea()}");
            Console.WriteLine($"Rectangle: {rect2.GetArea()}");
            Console.WriteLine($"Rectangle: {rect3.GetArea()}");

            Console.WriteLine($"Rectangle count: {Rectangle.Count}");
        }

        private static void PrintRactangle(Rectangle rect)
        {
            Console.WriteLine($"Width: {rect.Width}; Height: {rect.Height}; Area: {rect.GetArea()}");
        }
    }
}