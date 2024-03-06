namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount();
            Console.WriteLine("How much moeny would you like to deposit?");

            var deposit = double.Parse(Console.ReadLine());

            account.Deposit(deposit);

            Console.WriteLine($"Your balance is ${account.GetBalance()}.");
        } 
    }
}
