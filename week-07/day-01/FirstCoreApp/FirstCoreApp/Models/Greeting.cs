using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstCoreApp.Models
{
    public class Greeting
    {
        public Greeting(string name)
        {
            Id = 1;
            Content = "Hello " + name;
        }

        public long Id { get; set; }
        public string Content { get; set; }
    }

    
}
