using System;

namespace DivideByZero
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a function that takes a number
            // divides ten with it,
            // and prints the result.
            // It should print "fail" if the parameter is 0
            Tizetmivelosszam();
            Console.ReadKey();
        }
        public static double Tizetmivelosszam()
        {
            Console.WriteLine("Adj meg egy számot: ");
            double asd = Convert.ToInt32(Console.ReadLine());
            double result = 0;
            if (asd!=0)
            {
                result = 10 / asd;
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("fail");
            }
            return result;

            
        }
    }
}
