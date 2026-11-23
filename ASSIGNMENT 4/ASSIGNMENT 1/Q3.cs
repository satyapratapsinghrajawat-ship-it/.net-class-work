using System;

class Employee
{
    public string Name { get; set; }
    public double BasicSalary { get; set; }
    public int Experience { get; set; }

    public double Bonus
    {
        get
        {
            if (Experience >= 10)
                return BasicSalary * 0.20;
            else if (Experience >= 5)
                return BasicSalary * 0.10;
            else
                return BasicSalary * 0.05;
        }
    }
}

class Program2
{
    static void Main()
    {
        Employee e = new Employee();

        e.Name = "Rahul";
        e.BasicSalary = 30000;
        e.Experience = 6;

        Console.WriteLine("Employee Name: " + e.Name);
        Console.WriteLine("Basic Salary: " + e.BasicSalary);
        Console.WriteLine("Experience: " + e.Experience + " years");
        Console.WriteLine("Bonus: " + e.Bonus);
    }
}