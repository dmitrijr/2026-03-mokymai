namespace HelloWorld
{
    public class Rectangle
    {
        public static int Count { get; private set; }

        public double Height { get; set; }
        public double Width { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;

            Count++;
        }

        public double GetArea()
        {
            return Width * Height;
        }
    }
}