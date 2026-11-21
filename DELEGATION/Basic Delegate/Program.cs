using System;

class Program
{
    delegate void CalculateSum(int a, int b);

    static void Add(int a, int b)
    {
        int sum = a + b;
        Console.WriteLine("Sum = " + sum);
    }

    static void Main()
    {
        CalculateSum obj = Add;
        obj(10, 20);
    }
}