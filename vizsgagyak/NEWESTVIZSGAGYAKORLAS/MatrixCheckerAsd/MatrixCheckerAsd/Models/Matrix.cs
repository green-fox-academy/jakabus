using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MatrixCheckerAsd.Models
{
    public class Matrix
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string MatrixAsString { get; set; }
        [NotMapped]
        public List<List<string>> MatrixAsList { get; set; }
        [NotMapped]
        public int[][] theMatrix { get; set; }
        public bool IsSquare { get; set; }
        public bool IsIncreasing { get; set; }
        public string ResultMessage { get; set; }

    }
}
