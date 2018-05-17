using System;
using System.Collections.Generic;

namespace AppendA
{
    class Program
    {
        static void Main(string[] args)
        {
            var far = new List<string> { "kuty", "macsk", "kacs", "rók", "halacsk" };
            // Create a method called AppendA() that adds "a" to every string in the far list.
            // The parameter should be a list.

            //Console.WriteLine(AppendA(far));
            // Expected output: "kutya", "macska", "kacsa", "róka", "halacska"


            foreach (string i in AppendA(far))
            {
                Console.WriteLine("{0}\t",i.ToString());
            }
            Console.ReadKey();
        }
        public static List<string> AppendA(List<string> lista)
        {
            int a = lista.Count;
            for (int i = 0; i < a; i++)
            {
                lista[i] += "a";
            }
            return lista;
        }
    }
}
