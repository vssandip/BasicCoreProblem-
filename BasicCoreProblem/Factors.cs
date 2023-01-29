using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class Factors
    {

       public static void factors()
        {
            int fact = 1;

            Console.WriteLine("Enter a number");


            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= num; i++)

            {

                fact = fact * i;

            }

            Console.WriteLine("Factorial of" + num + "is" + fact);
        }
    }
}
