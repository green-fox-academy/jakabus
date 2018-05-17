using System;
using System.IO;

namespace WriteSingleLines
{
    class Program
    {
        static void Main(string[] args)
        {
            // Open a file called "my-file.txt"
            // Write your name in it as a single line
            // If the program is unable to write the file,
            // then it should print an error message like: "Unable to write file: my-file.txt"

            try
            {
                using (StreamWriter sw = new StreamWriter("file.txt"))
                {
                    sw.WriteLine("Jakab Akos");
                }
            }
            catch (Exception )
            {
                Console.WriteLine("Unable to write file!");
                throw;
            }
            Console.WriteLine(File.ReadAllText("file.txt"));


            Console.ReadKey();
        }
    }
}
