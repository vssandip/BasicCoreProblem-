using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class Swap_Two_Numbers
    {
       public static void swap_Two_Numbers()
        {
            int a, b, temp;

            Console.WriteLine("Enter first number: ");

            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number: ");

            b = int.Parse(Console.ReadLine());

            temp = a;

            a = b;

            b = temp;

            Console.WriteLine("After swapping {0},{1}", a, b);
        }
    }
}
