using System;
namespace EncapsulationInClass
{
    public class BankAccount
    {
        public double balance;

        public BankAccount(double amount)
        {
            balance = amount;
        }

        public void Deposit(double amount)
        {
            balance += amount;
        }

        public double GetBalance()
        {
            return balance;  
        }

        public void Withdraw(double amount)
        {
            balance -= amount;
        }
    }
}
