using System;

class Class1
{
    private double celsius;

    public double Celsius
    {
        get { return celsius; }
        set
        {
            if (value >= -273.15)
                celsius = value;
            else
                Console.WriteLine("Invalid Temperature");
        }
    }

    public double Fahrenheit
    {
        get
        {
            return (Celsius * 9 / 5) + 32;
        }
    }
}

class Program21
{
    static void Main()
    {
        Class1 obj1 = new Class1();

        obj1.Celsius = 25;

        Console.WriteLine("Celsius: " + obj1.Celsius);
        Console.WriteLine("Fahrenheit: " + obj1.Fahrenheit);
    }
}