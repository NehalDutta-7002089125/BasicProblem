using System;

namespace UC_4_harmonicNo
{
    internal class Program
    {
        static void Main(string[] args)
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
