using System;
using System.Collections.Generic;
using System.IO;

namespace WordFreq
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = "input.txt";
            string outputFilename = "output.txt";

            //FileRead(filename, 2);
            FileWrite(outputFilename, FileRead(filename, 2));

            Console.ReadLine();
        }

        public static string[] FileRead(string filename, int freq)
        {
            string[] lines;
            try
            {
                lines = File.ReadAllLines(filename);
            }
            catch (FileNotFoundException)
            {
                lines = new string[0];
                Console.WriteLine("No such File!");
            }

            List<string> words = new List<string>();

            foreach (string line in lines)
            {
                foreach (string word in line.Split(' '))
                {
                    words.Add(word);
                }
            }

            Dictionary<string, int> dict = new Dictionary<string, int>();

            foreach (string word in words)
            {
                if (!dict.ContainsKey(word))
                {
                    dict[word] = 1;
                }
                else
                {
                    dict[word]++;
                }
            }

            List<string> finalWords = new List<string>();

            foreach (KeyValuePair<string, int> word in dict)
            {
                if (word.Value==freq)
                {
                    finalWords.Add(word.Key);
                }
            }

            string[] finalWordsArray = new string[finalWords.Count];

            for (int i = 0; i < finalWords.Count; i++)
            {
                finalWordsArray[i] = finalWords[i];
            }

            return finalWordsArray;
        }

        public static void FileWrite(string outputFilename, string[] words)
        {
            if (File.Exists(outputFilename))
            {
                Console.WriteLine("the file allready exists. ill rewrite it");
                File.WriteAllLines(outputFilename, words);
            }
            else
            {
                File.WriteAllLines(outputFilename, words);
            }

        }
    }
}
