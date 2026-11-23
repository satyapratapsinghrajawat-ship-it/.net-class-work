using System;

class Class4
{
    public static double CalculatePercentage(double obtained, double total)
    {
        return (obtained / total) * 100;
    }

    public static string CalculateGrade(double percentage)
    {
        if (percentage >= 90)
            return "A";
        else if (percentage >= 75)
            return "B";
        else if (percentage >= 60)
            return "C";
        else if (percentage >= 40)
            return "D";
        else
            return "Fail";
    }

    public static double AttendancePercentage(int present, int total)
    {
        return ((double)present / total) * 100;
    }
}

class Program
{
    static void Main()
    {
        double p = Class4.CalculatePercentage(450, 500);
        string g = Class4.CalculateGrade(p);
        double a = Class4.AttendancePercentage(80, 100);

        Console.WriteLine("Percentage: " + p);
        Console.WriteLine("Grade: " + g);
        Console.WriteLine("Attendance: " + a + "%");
    }
}
