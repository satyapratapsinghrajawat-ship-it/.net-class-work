using System;

class Class3
{
    public int EmployeeId { get; set; }
    public string Name { get; set; }
    public double BasicSalary { get; set; }

    public double HRA
    {
        get { return BasicSalary * 0.20; }
    }

    public double DA
    {
        get { return BasicSalary * 0.10; }
    }

    public double GrossSalary
    {
        get { return BasicSalary + HRA + DA; }
    }

    public double Tax
    {
        get
        {
            if (GrossSalary > 100000)
                return GrossSalary * 0.20;
            else if (GrossSalary > 50000)
                return GrossSalary * 0.10;
            else
                return GrossSalary * 0.05;
        }
    }

    public double NetSalary
    {
        get { return GrossSalary - Tax; }
    }
}

class Program1234
{
    static void Main()
    {
        Class3 obj1 = new Class3();

        obj1.EmployeeId = 101;
        obj1.Name = "Rahul";
        obj1.BasicSalary = 80000;

        Console.WriteLine("Employee Salary Statement");
        Console.WriteLine("-------------------------");
        Console.WriteLine("Employee ID: " + obj1.EmployeeId);
        Console.WriteLine("Name: " + obj1.Name);
        Console.WriteLine("Basic Salary: " + obj1.BasicSalary);
        Console.WriteLine("HRA: " + obj1.HRA);
        Console.WriteLine("DA: " + obj1.DA);
        Console.WriteLine("Gross Salary: " + obj1.GrossSalary);
        Console.WriteLine("Tax: " + obj1.Tax);
        Console.WriteLine("Net Salary: " + obj1.NetSalary);
    }
}