using System;
using System.Collections.Generic;

namespace testGyak
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers = { 1, 7, 2, 3, 9, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("[" + String.Join(", ", Method2(numbers)) + "]");
            //Method2(numbers);


            Console.ReadLine();

        }
        public static List<int> Method(int[] numbers)
        {
            List<int> even = new List<int>();

            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    even.Add(number);
                }
            }

            return even;
        }

        public static List<int> Method2(int[] numbers)
        {
            List<int> mindenmasodik = new List<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (i % 2 != 0)
                {
                    mindenmasodik.Add(numbers[i]);
                }
            }

            return mindenmasodik;
        }

    }
}
