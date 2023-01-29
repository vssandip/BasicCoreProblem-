using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class Alphabet_is_Vowel_or_Consonant
    {
       public static void alphabet_is_Vowel_or_Consonant()
        {
            Console.WriteLine("Enter an Alphabet");

            char c = Convert.ToChar(Console.ReadLine());

            switch (c)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':

                    Console.WriteLine(c + " is a vowel");

                    break;

                default:

                    Console.WriteLine(c + " is a consonant");

                    break;
            }
        }
    }
}
