using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace HighSchoolMuzikel
{
    class Logger
    {
        static string filename = "log.txt";

        public static void LogLine(string line)
        {
            try
            {
                List<string> lineToAppend = new List<string>();
                lineToAppend.Add(line);
                
                File.AppendAllLines(filename,lineToAppend);
            }
            catch (FileLoadException)
            {
                Console.WriteLine("bibi");
            }
        }
    }
}
