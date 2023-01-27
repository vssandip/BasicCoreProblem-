using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class FlipCoin
    {

       public static void flipcoin()
        {
            int HeadCount = 0;

            int TossCount = 0;

            double Hper = 0;

            double Tper = 0;

            Console.WriteLine("Enter the number of flip");

            int Flips = Convert.ToInt32(Console.ReadLine());

            if (Flips > 0)
            {
                for (int i = 0; i < Flips; i++)
                {
                    Random random = new Random();

                    int number = random.Next(2);

                    Console.WriteLine(number);

                    if (number == 0)
                    {
                        TossCount++;
                    }
                    else
                    {
                        HeadCount++;
                    }
                }
                Hper = HeadCount * 100 / Flips;

                Tper = TossCount * 100 / Flips;

                Console.WriteLine("Hper" + Tper);

                Console.WriteLine("Tper" + Hper);
            }
        }
    }

}