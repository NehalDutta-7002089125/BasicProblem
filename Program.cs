using System;

namespace UC_1_Flipcoin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int HC = 0;

            int TC = 0;

            double Hper = 0;

            double Tper = 0;

            Console.WriteLine("Enter the number of flip");

            int Flips = Convert.ToInt32(Console.ReadLine());

            if (Flips > 0)
            {
                for (int i = 0; i < Flips; i++)
                {
                    Random random = new Random();

                    int number = random.Next(2);

                    Console.WriteLine(number);

                    if (number == 0)
                    {
                        TC++;
                    }
                    else
                    {
                        HC++;
                    }
                }
                Hper = HC * 100 / Flips;

                Tper = TC * 100 / Flips;

                Console.WriteLine("headpercentage" + Tper);

                Console.WriteLine("tailpercentage" + Hper);
            }
        }
    }
}
