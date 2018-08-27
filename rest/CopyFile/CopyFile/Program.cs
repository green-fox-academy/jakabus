using System;
using System.IO;
using System.Collections.Generic;

namespace CopyFile
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a function that reads all lines of a file and writes the read lines to an other file (a.k.a copies the file)
            // It should take the filenames as parameters
            // It should return a boolean that shows if the copy was successful
            using (StreamWriter sw = new StreamWriter("filefrom.txt"))
            {
                sw.WriteLine("Jakab Akos vagyok");
                sw.WriteLine("Ezt masold majd at egy uj txt");
                sw.WriteLine("file-ba kosz!");
            }

            CopyFromTo("filefrom.txt", "fileto.txt");
            Console.ReadKey();

        }
        public static void CopyFromTo(string fileCopyFrom, string fileCopyTo)
        {
            string line;
                        
            using (StreamReader sr = new StreamReader(fileCopyFrom))
            {
                using (StreamWriter sw = new StreamWriter(fileCopyTo))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        sw.WriteLine(sr.ReadLine());
                    }
                }
            }
            
            
            
        }
    }
}
