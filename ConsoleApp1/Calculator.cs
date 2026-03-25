namespace HelloWorld
{
    public class Calculator
    {
        public double Add(double b, int a)
        {
            return a + b;
        }

        public int Add(int a, double b)
        {
            return a + (int)b;
        }

        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        public double Add(double a, double b, double c)
        {
            return a + b + c;
        }

    }
}