using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    class Monkey : Animal
    {
        public Monkey(string name) : base(name)
        {

        }

        public Monkey(string name, int age, string gender) : base(name, age, gender)
        {

        }

        public override bool IsHungry()
        {
            Random rNaOnTd = new Random();
            int num = rNaOnTd.Next(0, 2);

            if (num == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
