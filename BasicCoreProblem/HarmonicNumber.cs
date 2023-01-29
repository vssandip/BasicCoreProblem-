using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class HarmonicNumber
    {
       public static void harmonicNumber()
        {
            int i, num;

            Console.WriteLine("Enter a number:");

            num = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= num; i++)

            {
                Console.Write("1/{0}+", i);

            }
        }
    }
}
