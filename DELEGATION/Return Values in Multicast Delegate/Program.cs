using System;

class Program
{
    delegate int Calculator(int a, int b);

    static int Addition(int a, int b)
    {
        return a + b;
    }

    static int Subtraction(int a, int b)
    {
        return a - b;
    }

    static int Multiplication(int a, int b)
    {
        return a * b;
    }

    static int Division(int a, int b)
    {
        return a / b;
    }

    static void Main()
    {
        Calculator obj = Addition;
        obj += Subtraction;
        obj += Multiplication;
        obj += Division;

        foreach (Calculator method in obj.GetInvocationList())
        {
            int result = method(20, 10);
            Console.WriteLine(result);
        }
    }
}