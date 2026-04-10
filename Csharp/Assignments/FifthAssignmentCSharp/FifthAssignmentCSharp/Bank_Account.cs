using System;

public class InsufficientBalanceException : Exception
{
    public InsufficientBalanceException(string message) : base(message)
    {
    }
}
public class BankAccount
{
    private double balance;

  
    public BankAccount(double initialBalance)
    {
        balance = initialBalance;
    }

    public void Deposit(double amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Deposit amount must be positive");

        balance += amount;
        Console.WriteLine("Deposited: " + amount);
    }

    public void Withdraw(double amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Withdrawal amount must be positive");

        if (amount > balance)
            throw new InsufficientBalanceException("Not enough balance!");

        balance -= amount;
        Console.WriteLine("Withdrawn: " + amount);
    }

   
    public void ShowBalance()
    {
        Console.WriteLine("Current Balance: " + balance);
    }
}