using System;
using System.IO;


namespace Count_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a function that takes a filename as string,
            // then returns the number of lines the file contains.
            // It should return zero if it can't open the file, and
            // should not raise any error.
            using (StreamWriter sr = new StreamWriter("file.txt"))
            {
                sr.WriteLine("Egyszer");
                sr.WriteLine("Volt");
                sr.WriteLine("Hol");
                sr.WriteLine("Nem");
                sr.WriteLine("Volt");
                sr.WriteLine("Egyszer");
                sr.WriteLine("Akiboi");
            }
            Console.WriteLine(ContentCounter("file.txt"));

            Console.ReadKey();
        }
        public static int ContentCounter(string filename)
        {
            int counter = 0;
            string line;

            using (StreamReader sr = new StreamReader(filename))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}
