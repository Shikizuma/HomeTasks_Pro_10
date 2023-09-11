namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new SavingsAccount();
            account.Deposit(1000);
            account.Withdraw(500);
        }
    }
}