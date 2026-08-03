using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp52
{
    internal class question1
    {
        public static void Run()
        {
            string name;
            int rollNo;
            float marks;
            Console.Write("Enter Student Name: ");
            name = Console.ReadLine();
            Console.Write("Enter Roll Number: ");
            rollNo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Marks: ");
            marks = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("\n----- Student Details -----");
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Roll Number : " + rollNo);
            Console.WriteLine("Marks : " + marks);
            Console.ReadKey();
        }
    }
}
