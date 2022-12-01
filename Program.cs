using System;

namespace UC_6_RemainderQuotient
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int Dividend = 22, Divisor = 2;

               int Quotient = Dividend / Divisor;

          int Remainder = Dividend % Divisor;

            Console.WriteLine("Dividend: {0} Divisor:{1}", Dividend, Divisor);

         Console.WriteLine("Qotient = " + Quotient);
              
                Console.WriteLine("Remainder = " + Remainder);
        }
    }
}
