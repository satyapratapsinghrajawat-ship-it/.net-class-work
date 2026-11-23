using System;

static class Class12
{
    public static string ConnectionString = "Server=localhost;Database=University";
    public static string ApplicationName = "Student Management System";

    public static void Display()
    {
        Console.WriteLine("Application Name: " + ApplicationName);
        Console.WriteLine("Database Connection: " + ConnectionString);
    }
}

class Program765
{
    static void Main()
    {
        Class12.Display();
    }
}