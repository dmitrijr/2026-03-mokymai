namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rect = new Rectangle(10.2, 5.7);
            Reset(rect);

            Console.WriteLine($"Width: = {rect.Width}; Height = {rect.Height}");
        }

        private static void Reset(Rectangle rectangle)
        {
            rectangle.Width = 0;
            rectangle.Height = 0;
        }

        private static void ParamByValue()
        {
            var i = 3;
            Console.WriteLine($"i = {i}");
            Increase(i);
            Console.WriteLine("=========");
            Console.WriteLine($"i = {i}");
        }

        public static int Increase(int number)
        {
            number++;
            Console.WriteLine($"increase: i = {number}");

            return number;
        }

        private static void PrintRactangle(Rectangle rect)
        {
            Console.WriteLine($"Width: {rect.Width}; Height: {rect.Height}; Area: {rect.GetArea()}");
        }
    }
}