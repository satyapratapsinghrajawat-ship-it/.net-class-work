using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp52
{
    internal class question9
    {
        public static void Run()
        {
            int num, rem, rev = 0, temp;

            Console.Write("Enter a Number: ");
            num = Convert.ToInt32(Console.ReadLine());

            temp = num;

            while (num > 0)
            {
                rem = num % 10;
                rev = rev * 10 + rem;
                num = num / 10;
            }

            if (temp == rev)
                Console.WriteLine("Palindrome Number");
            else
                Console.WriteLine("Not a Palindrome Number");

            Console.ReadKey();
        }

    }
}
