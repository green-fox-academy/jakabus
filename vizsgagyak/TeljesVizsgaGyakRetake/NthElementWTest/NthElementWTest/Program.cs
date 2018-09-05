using System;
using System.Collections.Generic;

namespace NthElementWTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 2, 4, 10, 34, 3, 16, 3, 21 };
            NthElement(numbers, 2);
            
            Console.ReadLine();
        }

        public static double NthElement(int[] numbers, int n)
        {
            if (n > numbers.Length)
            {
                Console.WriteLine("no valid element");
                return 0;
            }
            else
            {
                double[] selNums = new double[(numbers.Length / n) + 1];
                int selNumCounter = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    int realI = i + 1;
                    if (realI % n == 0)
                    {
                        selNums[selNumCounter] = Convert.ToDouble(numbers[i]);
                        selNumCounter++;
                    }
                }
                double sum = 0;
                double theRealDeal;
                for (int i = 0; i < selNums.Length; i++)
                {
                    sum += selNums[i];
                }
                theRealDeal = sum / selNumCounter;
                Console.WriteLine("{0}", theRealDeal);
                return theRealDeal;
            }
        }
    }
}
