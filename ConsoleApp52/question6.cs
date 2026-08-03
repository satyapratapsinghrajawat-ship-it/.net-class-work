using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp52
{
    internal class question6
    {
        public static void Run()
        {
            int n;

            Console.Write("Enter the value of N: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEven Numbers:");
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                    Console.Write(i + " ");
            }

            Console.WriteLine("\n\nOdd Numbers:");
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 != 0)
                    Console.Write(i + " ");
            }

            Console.ReadKey();
        }
    }
}
