using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp52;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\n===================================");
            Console.WriteLine("Assignment 1 All 10 Question ");
            Console.WriteLine("Devloped By Satya pratap singh");
            Console.WriteLine("All CopyRight Reserved By Satya pratap singh");

            int choice;

            do
            {
                Console.WriteLine("\n===================================");
                Console.WriteLine(" Assignment 1: All 10 Questions    ");
                Console.WriteLine(" Developed By Satya pratap singh                ");
                Console.WriteLine("===================================");
                Console.WriteLine("1.  Student Details");
                Console.WriteLine("2.  Arithmetic Operations");
                Console.WriteLine("3.  Positive / Negative / Zero");
                Console.WriteLine("4.  Grade Calculation");
                Console.WriteLine("5.  Simple Calculator");
                Console.WriteLine("6.  Even & Odd Numbers (1 to N)");
                Console.WriteLine("7.  Factorial of a Number");
                Console.WriteLine("8.  Prime Number Check");
                Console.WriteLine("9.  Palindrome Number Check");
                Console.WriteLine("10. Menu Driven Program");
                Console.WriteLine("0.  Exit");
                Console.WriteLine("===================================");
                Console.Write("Enter Question Number to Run (0-10): ");

                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input! Please enter a number.");
                    continue;
                }

                Console.WriteLine("\n-----------------------------------");

                switch (choice)
                {
                    case 1:
                        question1.Run(); // Calls Question1 file
                        break;
                    case 2:
                        question2.Run();
                        break;
                    case 3:
                        question3.Run();
                        break;
                    case 4:
                        question4.Run();
                        break;
                    case 5:
                        question5.Run();
                        break;
                    case 6:
                        question6.Run();
                        break;
                    case 7:
                        question7.Run();
                        break;
                    case 8:
                        question8.Run();
                        break;
                    case 9:
                        question9.Run();
                        break;
                    case 10:
                        question10.Run();
                        break;
                    case 0:
                        Console.WriteLine("Exiting program... Good Luck!");
                        break;
                    default:
                        Console.WriteLine("Invalid Choice! Please enter 0 to 10.");
                        break;
                }

            } while (choice != 0);


        }
    }
}
