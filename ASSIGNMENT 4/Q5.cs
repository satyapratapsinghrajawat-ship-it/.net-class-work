using System;

record Class9(int RollNumber, string Name, string Course, int Semester);

class Program87
{
    static void Main()
    {
        Class9 s1 = new Class9(101, "Rahul", "MCA", 2);
        Class9 s2 = new Class9(101, "Rahul", "MCA", 2);

        Console.WriteLine("Student 1: " + s1);
        Console.WriteLine("Student 2: " + s2);
        Console.WriteLine("Are Both Students Equal: " + (s1 == s2));
    }
}