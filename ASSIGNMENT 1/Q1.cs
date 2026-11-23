using System;

class BankAccount
{
    public string AccountNumber { get; set; }

    private double balance;

    public double Balance
    {
        get { return balance; }
        set
        {
            if (value >= 0)
                balance = value;
        }
    }

    public void Deposit(double amount)
    {
        if (amount > 0)
            Balance += amount;
        else
            Console.WriteLine("Invalid deposit amount");
    }
}

class Q1
{
    static void Main()
    {
        BankAccount account = new BankAccount();

        account.AccountNumber = "1234567890";
        account.Balance = 5000;

        account.Deposit(2000);

        Console.WriteLine("Account Number: " + account.AccountNumber);
        Console.WriteLine("Final Balance: " + account.Balance);
    }
}