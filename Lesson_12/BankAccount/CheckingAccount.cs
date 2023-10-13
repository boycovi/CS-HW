﻿namespace BankAccount
{
    internal class CheckingAccount : BankAccount
    {
        double overdraftLimit;
        public CheckingAccount(string accountHolder,double balance, double overdraftLimit) : base(accountHolder, balance)
        {
            this.overdraftLimit = overdraftLimit;
        }
        public override double Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
            }
            return balance;
        }

        public override void DisplayAccountInfo()
        {
            Console.WriteLine("Account Information for Checking Account:");
            Console.WriteLine($"Account Number: {accountNumber}");
            Console.WriteLine($"Account Holder: {accountHolder}");
            Console.WriteLine($"Balance: {balance}");
            Console.WriteLine($"Overdraft Limit: {overdraftLimit}");
        }

        public override double Withdraw(double amount)
        {
            if (amount > 0)
            {
                if (balance - amount >= -overdraftLimit)
                {
                    balance -= amount;
                }
                else
                {
                    Console.WriteLine("Withdrawal amount exceeds overdraft limit.");
                }
            }
            return balance;
        }
    }
}