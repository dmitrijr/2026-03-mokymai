namespace ConsoleApp1.Exceptions
{
    public class NonPositiveValueException : Exception
    {
        public NonPositiveValueException(string message) : base(message)
        {

        }
    }
}