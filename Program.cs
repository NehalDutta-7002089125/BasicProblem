using System;

namespace Powerof2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num >= 0 && num <= 40)
            {
                for (int i = 0; i < num; i++)
                {
                    Console.WriteLine(Math.Pow(i, 2));
                }
            }
            else
            {
                Console.WriteLine("Enter the number betwwen 2 to 40");
            }
        }
    }
}
