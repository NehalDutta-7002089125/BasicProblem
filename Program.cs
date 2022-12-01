using System;

namespace UC_6_EvenorOdd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number: ");

              int n = int.Parse(Console.ReadLine());

            if (n %2 == 0)

            {

                Console.WriteLine(n+ " is a Even Number.");

            }
            else

            {

                Console.WriteLine(n+ " is a Odd Number.");

            }
        }
    }
}
