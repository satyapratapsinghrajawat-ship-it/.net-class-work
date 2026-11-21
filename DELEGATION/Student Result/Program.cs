using System;

class Program
{
    delegate void StudentResult(string name, int marks);

    static void DisplayDetails(string name, int marks)
    {
        Console.WriteLine("Student Name: " + name);
        Console.WriteLine("Marks: " + marks);
    }

    static void CheckResult(string name, int marks)
    {
        if (marks >= 40)
            Console.WriteLine("Result: Pass");
        else
            Console.WriteLine("Result: Fail");
    }

    static void Main()
    {
        StudentResult obj = DisplayDetails;
        obj += CheckResult;

        obj("Amit", 75);
    }
}