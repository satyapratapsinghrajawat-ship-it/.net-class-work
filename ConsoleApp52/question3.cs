using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp52
{
    internal class question3
    {
        public static void Run()
        {
            int num;

            Console.Write("Enter a Number: ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num > 0)
            {
                Console.WriteLine("The number is Positive.");
            }
            else if (num < 0)
            {
                Console.WriteLine("The number is Negative.");
            }
            else
            {
                Console.WriteLine("The number is Zero.");
            }

            Console.ReadKey();
        }
    }
}
