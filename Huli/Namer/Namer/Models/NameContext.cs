using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Namer.Models
{
    public class NameContext : DbContext
    {
        public DbSet<Name> Names { get; set; }

        public NameContext(DbContextOptions<NameContext> options) :base(options)
        {

        }
    }
}
