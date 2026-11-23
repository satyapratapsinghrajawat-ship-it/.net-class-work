using System;

class Class2
{
    public string AccountNumber { get; set; }
    public string AccountHolder { get; set; }

    private double balance;

    public double Balance
    {
        get { return balance; }
    }

    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine("Amount Deposited Successfully");
        }
        else
        {
            Console.WriteLine("Invalid Deposit Amount");
        }
    }

    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= balance)
        {
            balance -= amount;
            Console.WriteLine("Amount Withdrawn Successfully");
        }
        else
        {
            Console.WriteLine("Invalid Withdrawal Amount");
        }
    }
}

class Program123
{
    static void Main()
    {
        Class2 obj1 = new Class2();

        obj1.AccountNumber = "123456789";
        obj1.AccountHolder = "Rahul";

        obj1.Deposit(5000);
        obj1.Withdraw(2000);

        Console.WriteLine("Account Number: " + obj1.AccountNumber);
        Console.WriteLine("Account Holder: " + obj1.AccountHolder);
        Console.WriteLine("Updated Balance: " + obj1.Balance);
    }
}