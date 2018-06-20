using System;
using System.Collections.Generic;

namespace boyzngirlz
{
    class Program
    {
        static void Main(string[] args)
        {
            var girls = new List<string> { "Eve", "Ashley", "Bözsi", "Kat", "Jane" };
            var boys = new List<string> { "Joe", "Fred", "Béla", "Todd", "Neef", "Jeff" };

            // Write a method that joins the two lists by matching one girl with one boy into a new list
            // Exepected output: "Eve", "Joe", "Ashley", "Fred"...

            //Console.WriteLine(MakingMatches(boys, girls));

            foreach (string i in MakingMatches(boys, girls))
            {
                Console.WriteLine("{0}\t", i.ToString());
            }


            Console.ReadKey();
        }
        public static List<string> MakingMatches(List<string> boy, List<string> girl)
        {
            List<string> equality = new List<string>();
            int a = 0;
            if (boy.Count <= girl.Count)
            {
                a = boy.Count;
            }
            else
            {
                a = girl.Count;
            }

            for (int i = 0; i < a; i++)
            {
                equality.Add(boy[i]);
                equality.Add(girl[i]);
            }
            
            
            
            

            return equality;
        }
    }
}
