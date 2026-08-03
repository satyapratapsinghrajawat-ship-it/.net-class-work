using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp52
{
    internal class question7
    {
        public static void Run()
        {
            int n;
            long factorial = 1;

            Console.Write("Enter a Positive Number: ");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                factorial = factorial * i;
            }

            Console.WriteLine("Factorial = " + factorial);

            Console.ReadKey();
        }
    }
}
