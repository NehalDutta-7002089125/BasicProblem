using System;

namespace UC5_Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fact =1;

            Console.WriteLine("Enter a number");


            int num = Convert.ToInt32(Console.ReadLine());

            for (int i=1; i<= num; i++)

            {

                fact = fact * i;

            }

            Console.WriteLine("Factorial of" + num + "is" + fact);
        }
    }
}
