using System;

sealed class Class7
{
    public string Name;
    public double Salary;

    public double CalculateTax()
    {
        if (Salary > 100000)
            return Salary * 0.20;
        else if (Salary > 50000)
            return Salary * 0.10;
        else
            return Salary * 0.05;
    }

    public double CalculateNetSalary()
    {
        return Salary - CalculateTax();
    }

    public void Display()
    {
        Console.WriteLine("Employee Name: " + Name);
        Console.WriteLine("Basic Salary: " + Salary);
        Console.WriteLine("Tax: " + CalculateTax());
        Console.WriteLine("Net Salary: " + CalculateNetSalary());
    }
}

class Program45
{
    static void Main()
    {
        Class7 obj1 = new Class7();

        obj1.Name = "Rahul";
        obj1.Salary = 80000;

        obj1.Display();
    }
}