using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NumberManipulator.Models
{
    public class Result
    {
        public string ResultMessage { get; set; }
        public string firstnumber { get; set; }
        public string secondnumber { get; set; }
        public string thirdnumber { get; set; }
        public string fourthnumber { get; set; }
        public List<Number> Numbers { get; set; }
        public double SumOfNumbers { get; set; }
        public double firstsquare { get; set; }
        public double secondsquare { get; set; }
        public double thirdsquare { get; set; }
        public double fourthsquare { get; set; }
    }
}
