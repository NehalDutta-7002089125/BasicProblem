using System;

namespace Powerof2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());

            int n;
            
            Console.WriteLine("Give the Exponent");
            
            n = Convert.ToInt32(Console.ReadLine());
            
            double value = Math.Pow(2, n);
            
            Console.WriteLine("Result is : " + value);
            }
        }
    }
}
