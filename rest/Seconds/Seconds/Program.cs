using System;
using System.Collections.Generic;
using System.IO;

namespace Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a function that takes a list as a parameter,
            // and returns a new list with every second element from the orignal list
            // example: [1, 2, 3, 4, 5] should produce [2, 4] - print this result

            List<int> list = new List<int>();
            int number = 1;
            for (int i = 0; i < 9; i++)
            {
                list.Add(number);
                number++;
            }
            Console.WriteLine("Original : ");
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i]);
            }
            Console.WriteLine("\r\nSolution : ");
            for (int i = 0; i < TakeEverySecond(list).Count; i++)
            {
                Console.Write(TakeEverySecond(list)[i]);
            }
            Console.ReadKey();
        }
        public static List<int> TakeEverySecond(List<int> list)
        {
            List<int> newList = new List<int>();
            for (int i = 0; i < list.Count; i = i+2)
            {
                newList.Add(list[i]);
            }
            return newList;
        }
    }
}
