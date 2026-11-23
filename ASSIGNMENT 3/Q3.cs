using System;

abstract class Class6
{
    public abstract double CalculateArea();
}

class Circle : Class6
{
    public double Radius;

    public override double CalculateArea()
    {
        return 3.14 * Radius * Radius;
    }
}

class Rectangle : Class6
{
    public double Length;
    public double Width;

    public override double CalculateArea()
    {
        return Length * Width;
    }
}

class Program1234
{
    static void Main()
    {
        Circle c = new Circle();
        c.Radius = 5;

        Rectangle r = new Rectangle();
        r.Length = 10;
        r.Width = 5;

        Console.WriteLine("Circle Area: " + c.CalculateArea());
        Console.WriteLine("Rectangle Area: " + r.CalculateArea());
    }
}