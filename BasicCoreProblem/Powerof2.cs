using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class Powerof2
    {
       public static void powerof2()
        {
            int n;

            Console.WriteLine("Give the Exponent");

            n = Convert.ToInt32(Console.ReadLine());

            double value = Math.Pow(2, n);

            Console.WriteLine("Result is : " + value);
        }

    }
}
