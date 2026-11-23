using System;

class Class5
{
    public string AccountNumber;
    public string HolderName;
    public double Balance;

    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            Balance += amount;
            Console.WriteLine("Amount Deposited Successfully");
        }
        else
            Console.WriteLine("Invalid Amount");
    }

    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= Balance)
        {
            Balance -= amount;
            Console.WriteLine("Amount Withdrawn Successfully");
        }
        else
            Console.WriteLine("Invalid Withdrawal");
    }

    public void Display()
    {
        Console.WriteLine("Account Number: " + AccountNumber);
        Console.WriteLine("Holder Name: " + HolderName);
        Console.WriteLine("Balance: " + Balance);
    }
}

class Program121
{
    static void Main()
    {
        Class5 obj1 = new Class5();

        obj1.AccountNumber = "123456789";
        obj1.HolderName = "Rahul";
        obj1.Balance = 10000;

        obj1.Deposit(5000);
        obj1.Withdraw(2000);
        obj1.Display();
    }
}