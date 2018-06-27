﻿using System;
using System.Collections.Generic;

namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            /*********************************************************
            *  Do not modify the code below except for test purpose *
            *********************************************************/

            List<Animal> animals = new List<Animal>{
            new Elephant("Dumbo", 15, "male"),
            new Elephant("Leopold"),
            new Lion("Simba", 3, "male"),
            new Lion("Elsa", 8, "female"),
            new Monkey("Uk"),
            new Monkey("Muk"),
            new Monkey("Ukmuk")
            };

            Worker kate = new Worker("Kate");
            Worker mandy = new Worker("Mandy");

            List<Worker> workers = new List<Worker>{
            kate,
            mandy
            };

            kate.SetAnimalsToLookAfter(animals.GetRange(0, 3));
            mandy.SetAnimalsToLookAfter(animals.GetRange(3, 4));
            

            for (int i = 0; i < 10; i++)
            {
                foreach (Worker worker in workers)
                {
                    worker.DoDailyRoutine();
                }
            }

            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal);
            }
            
        }
    }
}

