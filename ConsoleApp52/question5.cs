using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp52
{
    internal class question5
    {
        public static void Run()
        {
            int num1, num2, choice;

            Console.Write("Enter First Number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Second Number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");

            Console.Write("Enter Your Choice (1-4): ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Addition = " + (num1 + num2));
                    break;

                case 2:
                    Console.WriteLine("Subtraction = " + (num1 - num2));
                    break;

                case 3:
                    Console.WriteLine("Multiplication = " + (num1 * num2));
                    break;

                case 4:
                    if (num2 != 0)
                        Console.WriteLine("Division = " + (num1 / num2));
                    else
                        Console.WriteLine("Division by zero is not possible.");
                    break;

                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }

            Console.ReadKey();
        }
    }
}
