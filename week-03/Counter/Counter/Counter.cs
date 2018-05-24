using System;
using System.Collections.Generic;
using System.Text;

namespace Counter
{
    class Counter
    {
        public int number;
        public int declaredNumber;
        
        public int Counters()
        {
            number = 0;
            Console.WriteLine("Give me a number or ill use the default (0) :");
            string read = Console.ReadLine();
            if (read == "")
            {
                number = 0;
            }
            else
            {
                number = Convert.ToInt32(read);
            }
            Console.WriteLine("This is your number: {0}",number);
            declaredNumber = number;
            return number;
        }
        public int Add()
        {
            Console.WriteLine("Give me a number you want to add (+) to your number: ");
            int numbertobeadded = Convert.ToInt32(Console.ReadLine());
            number = number + numbertobeadded;
            Console.WriteLine("You added this number to it: {0}\tnow this is you number: {1}",numbertobeadded,number);
            return number;
        }
        public int AddOne()
        {
            number = number + 1;
            Console.WriteLine("Now i added 1 to your number\t now your number is: {0}",number);
            return number;
        }
        public void Get()
        {
            Console.WriteLine("Itt a számod: {0}", number);
        }
        public int Reset()
        {
            number = Convert.ToInt32(declaredNumber);
            Console.WriteLine("RESET TO INITIAL VALUE: {0}", number);
            return number;
        }
    }
}
