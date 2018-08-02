using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MatrixCheckerAsd.Models
{
    public class MatrixContext : DbContext
    {
        public DbSet<Matrix> Matrices { get; set; }

        public MatrixContext(DbContextOptions<MatrixContext> options) : base(options)
        {

        }
    }
}
