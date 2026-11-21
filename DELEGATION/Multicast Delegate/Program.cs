using System;

class Program
{
    delegate void Calculator(int a, int b);

    static void Addition(int a, int b)
    {
        Console.WriteLine("Addition = " + (a + b));
    }

    static void Subtraction(int a, int b)
    {
        Console.WriteLine("Subtraction = " + (a - b));
    }

    static void Multiplication(int a, int b)
    {
        Console.WriteLine("Multiplication = " + (a * b));
    }

    static void Division(int a, int b)
    {
        if (b != 0)
            Console.WriteLine("Division = " + ((double)a / b));
        else
            Console.WriteLine("Cannot divide by zero");
    }

    static void Main()
    {
        Calculator obj = Addition;
        obj += Subtraction;
        obj += Multiplication;
        obj += Division;

        obj(20, 10);
    }
}