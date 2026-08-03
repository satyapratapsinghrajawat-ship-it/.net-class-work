using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp52
{
    internal class question2 
    {
        public static void Run()
        {
            int num1, num2;

            Console.Write("Enter First Number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Second Number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nSum = " + (num1 + num2));
            Console.WriteLine("Difference = " + (num1 - num2));
            Console.WriteLine("Product = " + (num1 * num2));
            Console.WriteLine("Quotient = " + (num1 / num2));
            Console.WriteLine("Remainder = " + (num1 % num2));

            Console.ReadKey();
        }
    }
}  
