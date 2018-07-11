using BankOfSimba.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankOfSimba.Repositories
{
    public class BankContext : DbContext
    {
        public DbSet<BankAccount> BankAccounts { get; set; }

        public BankContext(DbContextOptions options) : base(options)
        {
            
        }
    }
}
