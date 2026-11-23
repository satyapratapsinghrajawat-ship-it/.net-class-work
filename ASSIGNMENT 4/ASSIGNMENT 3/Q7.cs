using System;

class Class11
{
    public string UniversityName;

    public class Department
    {
        public string DepartmentName;
        public string HODName;
        public int FacultyMembers;

        public void Display()
        {
            Console.WriteLine("Department Name: " + DepartmentName);
            Console.WriteLine("HOD Name: " + HODName);
            Console.WriteLine("Faculty Members: " + FacultyMembers);
        }
    }
}

class Program09
{
    static void Main()
    {
        Class11 obj1 = new Class11();
        obj1.UniversityName = "GLA University";

        Class11.Department obj2 = new Class11.Department();

        obj2.DepartmentName = "Computer Science";
        obj2.HODName = "Mr. Sharma";
        obj2.FacultyMembers = 25;

        Console.WriteLine("University: " + obj1.UniversityName);
        obj2.Display();
    }
}