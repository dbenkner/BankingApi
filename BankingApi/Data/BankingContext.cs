using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BankingApi.Models;

namespace BankingApi.Data
{
    public class BankingContext : DbContext
    {
        public BankingContext (DbContextOptions<BankingContext> options)
            : base(options)
        {
        }

        public DbSet<BankingApi.Models.Customer> Customers { get; set; } = default!;

        public DbSet<BankingApi.Models.Account> Accounts { get; set; } = default!;
        public DbSet<Transaction> Transactions { get; set; } = default!;
    }
}
