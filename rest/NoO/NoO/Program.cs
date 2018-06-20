using System;
using System.Collections.Generic;

namespace NoO
{
    class Program
    {
        static void Main(string[] args)
        {
            var List = new List<int> { 1, 2, 3, 4, 5 };

            // Write a method that checks if the arrayList contains "7" if it contains return "Hoorray" otherwise return "Noooooo"
            // The output should be: "Noooooo"
            // Do this again with a different solution using different list methods!

            Console.WriteLine(ContainsSeven(List));

            Console.ReadKey();
        }
        public static string ContainsSeven(List<int> lista)
        {
            string eredmeny;
            int a = 7;
            if (lista.Contains(a))
            {
                eredmeny = "Hoorray";
            }
            else
            {
                eredmeny = "Nooooooo";
            }

            return eredmeny;
        }

    }
}
