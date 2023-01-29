using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class ComputeQuotientandRemainder
    {
       public static void computeQuotientandRemainder()
        {

            int Dividend = 22, Divisor = 2;

            int Quotient = Dividend / Divisor;

            int Remainder = Dividend % Divisor;

            Console.WriteLine("Dividend: {0} Divisor:{1}", Dividend, Divisor);

            Console.WriteLine("Qotient = " + Quotient);

            Console.WriteLine("Remainder = " + Remainder);
        }
    }
}
