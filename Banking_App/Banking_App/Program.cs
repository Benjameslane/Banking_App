namespace Banking_App
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Person ben = new Person("Ben", "Lane");
            Person ryan = new Person("Ryan", "Smith");

            BankAccount bensAccount = new BankAccount(ben, 1000);
            Console.WriteLine(bensAccount.Balance);
        }
    }
}