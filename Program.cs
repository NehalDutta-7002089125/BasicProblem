using System;

namespace uc7_SwappingNo
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int a, b, temp;

            Console.WriteLine("Enter first number: ");

             a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number: ");

            b = int.Parse(Console.ReadLine());

            temp = a;

            a = b;

            b = temp;

            Console.WriteLine("After swapping {0},{1}", a, b);
        }
    }
}
