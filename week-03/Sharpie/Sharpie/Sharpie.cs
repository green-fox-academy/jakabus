using System;
using System.Collections.Generic;
using System.Text;

namespace Sharpie
{
    class Sharpie
    {
        public string color;
        public float width;
        public float Ink;
        

        public Sharpie(string color, float width)
        {
            this.color = color;
            this.width = width;
            this.Ink = 100;
        }
        public void use()
        {
            Ink--;
        }
    }
}
