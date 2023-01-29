using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class Largest_Among_Three_Numbers
    {
       public static void largest_Among_Three_Numbers()
        
        {
            Console.WriteLine("Enter 1st number:");

            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the 2nd number:");

            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the 3rd number:");

            int num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {

                if (num1 > num3)
                {
                    Console.WriteLine(num1 + " is the gratest among three");
                }
                else
                {
                    Console.WriteLine(num3 + " is the gratest among three");
                }
            }

            if (num2 > num3)
            {
                Console.WriteLine(num2 + " is the gratest among three");
            }
            else
            {
                Console.WriteLine(num3 + " is the gratest among three");
            }
        }
    }
}
