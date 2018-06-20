using System;

namespace Bunny
{
    class Program
    {
        static void Main(string[] args)
        {
            // We have a number of bunnies and each bunny has two big floppy ears.
            // We want to compute the total number of ears across all the bunnies recursively (without loops or multiplication).

            Console.WriteLine(BunnyEars(5));
            Console.ReadKey();

        }
        public static int BunnyEars(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 2;
            }
            else
            {
                return 2 + BunnyEars(n-1);
            }
        }

    }
}
