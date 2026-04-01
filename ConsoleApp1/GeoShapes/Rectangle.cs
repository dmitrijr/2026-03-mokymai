using ConsoleApp1.Exceptions;

namespace ConsoleApp1
{
    public class Rectangle : Shape
    {
        private double _width;
        public double Width
        {
            get => _width;
            set
            {
                if (value <= 0)
                    throw new NonPositiveValueException($"Invalid value: {value}");

                _width = value;
            }
        }
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