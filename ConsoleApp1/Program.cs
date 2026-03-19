namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rect1 = new Rectangle
            {
                Width = 10.2,
                Height = 5.7
            };

            var rect2 = new Rectangle();
            rect2.Width = 3.8;
            rect2.Height = 4.5;

            var rect3 = new Rectangle();

            PrintRactangle(rect1);
            PrintRactangle(rect2);
            PrintRactangle(rect3);
            Console.WriteLine("Hello world!");
        }

        private static void PrintRactangle(Rectangle rect)
        {
            Console.WriteLine($"Width: {rect.Width}; Height: {rect.Height}; Area: {rect.GetArea()}");
        }
    }
}