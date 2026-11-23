using System;
using System.Collections.Generic;

class Class10<T>
{
    List<T> data = new List<T>();

    public void Add(T item)
    {
        data.Add(item);
    }

    public void Display()
    {
        foreach (T item in data)
        {
            Console.WriteLine(item);
        }
    }
}

class Student
{
    public string Name;
    public Student(string name)
    {
        Name = name;
    }

    public override string ToString()
    {
        return "Student Name: " + Name;
    }
}

class Employee
{
    public string Name;
    public Employee(string name)
    {
        Name = name;
    }

    public override string ToString()
    {
        return "Employee Name: " + Name;
    }
}

class Program76
{
    static void Main()
    {
        Class10<Student> s = new Class10<Student>();
        s.Add(new Student("Rahul"));
        s.Add(new Student("Amit"));

        Class10<Employee> e = new Class10<Employee>();
        e.Add(new Employee("Rohit"));
        e.Add(new Employee("Vikas"));

        Console.WriteLine("Student Repository:");
        s.Display();

        Console.WriteLine("Employee Repository:");
        e.Display();
    }
}