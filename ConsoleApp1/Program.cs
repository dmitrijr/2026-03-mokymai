using System.Security.Principal;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var c = new Calculator();

            short s = 10;
            ushort us = 20;
            int i = 65535 + 32767 + 2; // -32,768 to 32,767 // 0 to 65,535

            s = (short)i;
            us = (ushort)i;

            long l;
            checked
            {
                l = long.MaxValue;
                i = (int)l;
            }

            double d = 2342.234;
            float f = 245.234f;

            f = (float)d;

            Console.WriteLine($"s = {s}; i = {i}; us = {us}; l = {l}; f = {f}; d = {d}");
            Console.WriteLine($"s = {short.MaxValue}; i = {int.MaxValue}; us = {ushort.MaxValue}");
        }

        private static void RefereceArrayCopy()
        {
            var sourceArray = new Rectangle[2];
            sourceArray[0] = new Rectangle(2, 3);
            sourceArray[1] = new Rectangle(5, 1);

            Console.WriteLine("before copy");
            PrintArray(sourceArray);

            var targetArray = new Rectangle[sourceArray.Length];
            Array.Copy(sourceArray, targetArray, sourceArray.Length);

            targetArray[1].Width = 7;

            Console.WriteLine("source");
            PrintArray(sourceArray);
            Console.WriteLine("target");
            PrintArray(targetArray);
        }

        private static void PrintArray(Rectangle[] array)
        {
            Console.WriteLine(string.Join(Environment.NewLine, array.Select(o => $"w: {o.Width}; h: {o.Height}")));
        }

        private static void ParamByReference()
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