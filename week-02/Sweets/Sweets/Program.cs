using System;
using System.Collections.Generic;

namespace Sweets
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<object>();
            list.Add("Cupcake");
            list.Add(2);
            list.Add("Brownie");
            list.Add(false);

            // Accidentally we added "2" and "false" to the list.
            // Your task is to change from "2" to "Croissant" and change from "false" to "Ice cream"
            // No, don't just remove the lines
            // Create a method called Sweets() which takes the list as a parameter.

            //Console.WriteLine(Sweets(list));
            // Expected output: "Cupcake", "Croissant", "Brownie", "Ice cream"


            foreach (object i in Sweets(list))
            {
                Console.WriteLine("{0}\t",i.ToString());
            }

            Console.ReadKey();
        }
        public static List<object> Sweets(List<object> lista)
        {
            int a = lista.Count;
            bool b = false;

            for (int i = 0; i < a; i++)
            {
                if (lista[i].GetType() == a.GetType())
                {
                    lista[i] = "Croissant";
                }
                if (lista[i].GetType() == b.GetType())
                {
                    lista[i] = "Ice Cream";
                }
            }

            return lista;
        }
    }
}
