using System;
using System.IO;

namespace CountA_s
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a function that takes a filename as string parameter,
            // counts the occurances of the letter "a", and returns it as a number.
            // If the file does not exist, the function should return 0 and not break.

            // example: on the input "afile.txt" the function should return 28 - print this result
            // example: on the input "not-a-file" the function should return 0 - print this result

            Console.WriteLine("{0}",TheACounter("aflie.txt"));
            Console.ReadKey();

        }
        public static int TheACounter(string filename)
        {
            int numberOfA = 0;
            string readLine;

            using (StreamReader sr = new StreamReader(filename))
            {
                while (sr.EndOfStream == true)
                {
                    readLine = sr.ReadLine();
                    for (int i = 0; i < readLine.Length; i++)
                    {
                        if (readLine[i] == 'a')
                        {
                            numberOfA++;
                        }
                    }
                }
            }
            return numberOfA;
        }
    }
}
