namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect3;
            rect3 = new Rectangle();
            rect3.Width = 7;

            Rectangle rect1;
            rect1 = new Rectangle
            {
                Width = 10.2,
                Height = 5.7
            };

            var rect2 = new Rectangle
            {
                Width = 3,
                Height = 8
            };

            for (int i = 0; i < 100; i++)
            {
                new Rectangle();
            }

            Console.WriteLine($"Rectangle count: {Rectangle.Count}");
        }

        private static void PrintRactangle(Rectangle rect)
        {
            Console.WriteLine($"Width: {rect.Width}; Height: {rect.Height}; Area: {rect.GetArea()}");
        }
    }
}