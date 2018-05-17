using System;
using System.Collections.Generic;

namespace Unique
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Create a function that takes a list of numbers as a parameter
            //  Returns a list of numbers where every number in the list occurs only once

            //  Example
            //  Console.WriteLine(Unique({ 1, 11, 34, 11, 52, 61, 1, 34}));
            //  should print: `[1, 11, 34, 52, 61]`

            int[] numbers = { 1, 11, 34, 11, 52, 61, 1, 34 };
            List<int> lista = new List<int>();
            
            for (int i = 0; i < 8; i++)
            {
                lista.Add(numbers[i]);
            }
            foreach (int i in lista)
            {
                Console.WriteLine("{0}\t",i.ToString());
            }
            Console.WriteLine("\t");
            foreach (int i in Szita(lista))
            {
                Console.WriteLine("{0}\t",i.ToString());
            }
            
            

            Console.ReadKey();
        }
        public static List<int> Szita(List<int> asd)
        {
            List<int> lista = new List<int>();

            foreach (int i in asd)
            {
                if (!lista.Contains(i))
                {
                    lista.Add(i);
                }
            }
            return lista;
        }
        
    }
}
