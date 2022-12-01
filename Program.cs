using System;

namespace UC_10_LargestNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st number:");

            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the 2nd number:");

            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the 3rd number:");

            int num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {

                if (num1 > num3)
                {
                    Console.WriteLine(num1 + " is the gratest among three");
                }
                else
                {
                    Console.WriteLine(num3 + " is the gratest among three");
                }
            }

            if (num2 > num3)
            {
                Console.WriteLine(num2 + " is the gratest among three");
            }
            else
            {
                Console.WriteLine(num3 + " is the gratest among three");
            }
        }
    }
}
