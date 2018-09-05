using System;
using System.Collections.Generic;
using System.IO;

namespace PrintEachLine
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that opens a file called "my-file.txt", then prints
            // each of lines form the file.
            // If the program is unable to read the file (for example it does not exists),
            // then it should print an error message like: "Unable to read file: my-file.txt"

            using (StreamWriter writer = new StreamWriter("file.txt"))
            {
                writer.WriteLine("Jakab Akos");
                writer.WriteLine("Program");
                writer.WriteLine("CsharP");
            }

            int szamolo = 0;
            string sor;

            StreamReader sr = new StreamReader("file.txt");

            while ((sor = sr.ReadLine()) != null)
            {
                Console.WriteLine(sor);
                Console.ReadKey();
                szamolo++;
            }

            
        }
    }
}
