using System;
using System.Collections.Generic;

namespace OrientationRetakeMatrix.Models
{
    public partial class Matrices
    {
        public int Id { get; set; }
        public byte? M1 { get; set; }
        public byte? M2 { get; set; }
        public byte? M3 { get; set; }
        public byte? M4 { get; set; }
        public byte? M5 { get; set; }
        public byte? M6 { get; set; }
        public byte? M7 { get; set; }
        public byte? M8 { get; set; }
        public byte? M9 { get; set; }
        public bool? UsableMatrix { get; set; }
    }
}
