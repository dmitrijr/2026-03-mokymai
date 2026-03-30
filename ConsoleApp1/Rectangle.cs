namespace HelloWorld
{
    public class Rectangle
    {
        public static int Count { get; private set; }

        public readonly Point Point = new Point(2, 3);
        public double Height { get; set; }
        public double Width { get; set; }

        public Rectangle()
        {
            Count++;
        }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;

            Count++;
        }

        public Rectangle(Rectangle sourceRect)
        {
            Width = sourceRect.Width;
            Height = sourceRect.Height;

            Count++;
        }

        public double GetArea()
        {
            return Width * Height;
        }
    }
}