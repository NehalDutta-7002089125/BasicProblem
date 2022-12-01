using System;

namespace uc9_Vowel
{
    internal class Program
    {
        static void Main(string[] args)
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

                    Console.WriteLine(c+ " is a vowel");

                    break;

                default:

                    Console.WriteLine(c+ " is a consonant");

                    break;
            }
        }
    }
}
