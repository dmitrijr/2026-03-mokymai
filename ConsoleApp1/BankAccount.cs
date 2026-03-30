namespace HelloWorld
{
    public class BankAccount
    {
        public const string Currency = "EUR";

        public void Withdraw(decimal amount)
        {
            const decimal maxAmount = 150000;

            if (amount > maxAmount)
                return;

            Console.WriteLine($"Withdrawing {amount} {Currency}");
        }
    }
}