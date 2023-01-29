using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class Number_is_Even_or_Odd
    {
       public static void number_is_Even_or_Odd()
        {
            Console.WriteLine("Enter a Number: ");

            int n = int.Parse(Console.ReadLine());

            if (n % 2 == 0)

            {

                Console.WriteLine(n + " is a Even Number.");

            }
            else

            {

                Console.WriteLine(n + " is a Odd Number.");

            }
        }
    }
}
