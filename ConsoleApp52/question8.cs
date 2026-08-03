using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp52
{
    internal class question8
    {
        public static void Run()
        {
            int n, i;
            bool isPrime = true;

            Console.Write("Enter a Number: ");
            n = Convert.ToInt32(Console.ReadLine());

            if (n <= 1)
            {
                Console.WriteLine("Not Prime");
            }
            else
            {
                for (i = 2; i <= n / 2; i++)
                {
                    if (n % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                    Console.WriteLine("Prime Number");
                else
                    Console.WriteLine("Not Prime Number");
            }

            Console.ReadKey();
        }
    }
}
