using System;
using System.Collections.Generic;

namespace Poker
{
    class Program
    {
        static void Main(string[] args)
        {

            //H = hearts S = Spades C = Clubs D = Diamonds

            string input = "Black: 2H 3D 5S 9C KD White: 2C 3H 4S 8C AH";
            //string input = "Black: 2H 4S 4C 2D 4H White: 2S 8S AS QS 3S";
            //string input = "Black: 2H 3D 5S 9C KD White: 2C 3H 4S 8C KH";
            //string input = "Black: 2H 3D 5S 9C KD White: 2D 3H 5C 9S KH";


            CardRead(input);
            Console.ReadLine();
        }

        public static List<List<string>> CardRead(string input)
        {
            List<List<string>> Cards = new List<List<string>>();
            List<string> Black = new List<string>();
            List<string> White = new List<string>();
            string[] words = input.Split(' ');
            for (int i = 1; i < 6; i++)
            {
                Black.Add(words[i]);
            }
            for (int j = 7; j < 12; j++)
            {
                White.Add(words[j]);
            }
            Cards.Add(Black);
            Cards.Add(White);
            return Cards;
        }


    }
}
