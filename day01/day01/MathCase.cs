using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day01
{
    internal class MathCase
    {
        /** case 1 : input bilangan 3 digit lalu koncersi ke dollar
         * input : 75rb, output : 50rb=1, 10rb=2, 5rb=1
        **/
        public static void ATM()
        {
            int digit1, digit2, digit3, sisa;
            Console.Write(" Enter Money : ");
            int number = Convert.ToInt32(Console.ReadLine());
            digit1 = number / 50_000;
            sisa = number % 50_000;

            digit2 = sisa / 10_000;
            sisa = sisa % 10_000;

            digit3 = sisa / 5000;
            sisa = sisa % 5000;

            Console.WriteLine("Rp. 50.000 = " + digit1 + "Rp.10.000 = " + digit2 + "Rp.5.000 = " + digit3); 
        }

        public static void SumDigit()
        {

        }

        public static void Fizzbuzz (int n)
        {
            for (int i = 1; i < n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine($"{i} FizzBuzz");
                }
                else if (i % 3 == 0 )
                {
                    Console.WriteLine($"{i} Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine($"{i} Buzz");
                }
                else
                {
                    Console.WriteLine($"{i}");
                }
            }
            {

            }
        }
    }
}
