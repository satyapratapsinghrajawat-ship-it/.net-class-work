using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp52
{
    internal class question4
    {
        public static void Run()
        {
            int marks;

            Console.Write("Enter Student Marks: ");
            marks = Convert.ToInt32(Console.ReadLine());

            if (marks >= 91 && marks <= 100)
                Console.WriteLine("Grade: O");
            else if (marks >= 81 && marks <= 90)
                Console.WriteLine("Grade: A+");
            else if (marks >= 71 && marks <= 80)
                Console.WriteLine("Grade: A");
            else if (marks >= 61 && marks <= 70)
                Console.WriteLine("Grade: B+");
            else if (marks >= 51 && marks <= 60)
                Console.WriteLine("Grade: B");
            else if (marks >= 0 && marks < 50)
                Console.WriteLine("Grade: Fail");
            else
                Console.WriteLine("Invalid Marks");

            Console.ReadKey();
        }
    }
}
