namespace HelloWorld
{
    public abstract class Shape
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point GetPoint()
        {
            return new Point(X, Y);
        }

        public abstract double GetArea();

        public abstract double GetPerimeter();

        public override string ToString()
        {
            return $"x: {X}; y: {Y}; a: {GetArea()}; p: {GetPerimeter()}";
        }
    }
}