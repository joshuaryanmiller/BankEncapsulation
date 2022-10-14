namespace BankEncapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();
            Console.WriteLine("How much money would you like to deposit?");
            account.Deposit(double.Parse(Console.ReadLine()));
            Console.WriteLine($"Your current balance is {account.GetBalance(),0:c}.");
        }
    }
}