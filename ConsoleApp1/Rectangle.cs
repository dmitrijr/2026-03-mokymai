namespace ConsoleApp1
{
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double widht, double height)
        {
            Width = widht;
            Height = height;
        }

        public override double GetArea()
        {
            return Width * Height;
        }

        public override double GetPerimeter()
        {
            return 2 * (Width + Height);
        }

        public override string ToString()
        {
            return $"w: {Width}; h: {Height}; {base.ToString()}";
        }
    }
}