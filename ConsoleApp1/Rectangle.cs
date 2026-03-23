namespace HelloWorld
{
    public class Rectangle
    {
        public static int Count { get; private set; }

        public double Height { get; set; }
        public double Width { get; set; }

        public Rectangle()
        {
            Count++;
        }

        public double GetArea()
        {
            return Width * Height;
        }
    }
}