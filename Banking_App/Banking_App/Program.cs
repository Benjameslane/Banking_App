namespace Banking_App
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Person Ben = new Person("Ben", "Lane");
            Person Ryan = new Person("Ryan", "Smith");

            BankAccount bensAccount = new BankAccount(Ben, 1000);
            BankAccount ryansAccount = new BankAccount(Ryan, 5000);

            Console.WriteLine("Total number of accounts: " + BankAccount.TotalAccounts);
            Console.WriteLine("Ben's Initial Balance: " + bensAccount.Balance);
            Console.WriteLine("Ryan's Initial Balance: " + ryansAccount.Balance);
            bensAccount.ApplyInterest();
            Console.WriteLine("Ben's Balance After Interest: " + bensAccount.Balance);
            ryansAccount.ApplyInterest();
            Console.WriteLine("Ryan's Balance After Interest: " + ryansAccount.Balance);

            bensAccount.Deposit(1500);
            Console.WriteLine(Ben.GetFullName() + " balance after deposit: " + bensAccount.Balance);

            Console.WriteLine("Bank's interest rate is: " + BankAccount.InterestRate + "%");
            Console.WriteLine("Ben's new balance after interest: " + bensAccount.Balance);

        }
    }
}