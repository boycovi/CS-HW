namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckingAccount checking = new CheckingAccount("Johnnyyyy Doe", 1000.0, 500.0);

            checking.Deposit(100);
            checking.Withdraw(1500.0);

            checking.DisplayAccountInfo();
            
            Console.WriteLine();
            checking.Withdraw(200);
            Console.WriteLine();


            SavingsAccount savings = new SavingsAccount("Jane Smith", 5000.0, 0.05);

            savings.Deposit(1000.0);
            savings.Withdraw(2000.0);

            savings.DisplayAccountInfo();
            savings.Withdraw(4500);
            Console.ReadKey();
        }
    }
}