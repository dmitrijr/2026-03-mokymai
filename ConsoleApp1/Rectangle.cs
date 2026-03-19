namespace HelloWorld
{
    public class Rectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public double GetArea()
        {
            return Width * Height;
        }

        public static string IamInRectangle()
        {
            return "I'am in rectangle";
        }
    }
}