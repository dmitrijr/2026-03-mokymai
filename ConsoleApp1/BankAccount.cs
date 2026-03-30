namespace HelloWorld
{
    public class BankAccount
    {
        public static string CurrencyStatic = "EUR";
        public const string CurrencyConst = "EUR";
        public readonly string Currency = "EUR";

        public BankAccount()
        {

        }

        public BankAccount(string currency)
        {
            Currency = currency;
        }

        public void Withdraw(decimal amount)
        {
            const decimal maxAmount = 150000;

            if (amount > maxAmount)
                return;

            Console.WriteLine($"Withdrawing {amount} {Currency}");
        }
    }
}