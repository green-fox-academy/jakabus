using System;

namespace String2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Given a string, compute recursively a new string where all the 'x' chars have been removed.

            Console.WriteLine(Xremover("xAnnax"));
            Console.ReadKey();
        }
        public static string Xremover(string word)
        {
            if (word == "")
            {
                return null;
            }
            if (word[0]=='x')
            {
                return Xremover(word.Remove(0, 1));
            }
            return word[0] + Xremover(word.Remove(0, 1));
            
        }
    }
}
