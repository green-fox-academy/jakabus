using Counter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Counter.Services
{
    public class CounterService : ICounter
    {
        
        private Numbercs storedValue;

        public CounterService()
        {
            storedValue = new Numbercs() { MyNumber = 0 };
        }

        public int Getnumber()
        {
            return storedValue.MyNumber;
        }

        public void Increase()
        {
            storedValue.MyNumber++;
        }
    }
}
