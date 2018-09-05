using System;
using System.Collections.Generic;
using System.Text;

namespace PetrolStation
{
    class Station
    {
        public int gasAmmount;


        public Station(Car car)
        {
            this.gasAmmount = 10000;

            gasAmmount = gasAmmount - (car.capacity - car.gasAmmount);
            car.gasAmmount = car.gasAmmount + (car.capacity - car.gasAmmount);

            Console.WriteLine("Stations capacity after refill: {0}", gasAmmount);
            Console.WriteLine("Cars gas ammount after refill: {0}",car.gasAmmount);

        }
    }
}
