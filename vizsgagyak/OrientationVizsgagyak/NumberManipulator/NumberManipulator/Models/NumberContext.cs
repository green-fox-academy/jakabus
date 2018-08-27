using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NumberManipulator.Models
{
    public class NumberContext : DbContext
    {
        public DbSet<Number> Numbers { get; set; }

        public NumberContext(DbContextOptions<NumberContext> options) : base(options)
        {

        }
    }
}
