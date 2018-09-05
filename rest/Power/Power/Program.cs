using System;

namespace Power
{
    class Program
    {
        static void Main(string[] args)
        {
            // Given base and n that are both 1 or more, compute recursively (no loops)
            // the value of base to the n power, so powerN(3, 2) is 9 (3 squared).

            Console.WriteLine(Power(2, 2));
            Console.ReadKey();
        }

        private static int Power(int baseInt, int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return baseInt = Power(baseInt, n - 1);
            }
        }
    }
}
