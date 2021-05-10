using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KP.Entity
{
    class UserContext : DbContext
    {
        public UserContext()
            : base("DbConnection")
        { }
        public DbSet<User> Users { get; set; }
        public DbSet<Tokens> Tokens { get; set; }
        public DbSet<HistoryDeposits> HistoryDeposits { get; set; }
        public DbSet<HistoryWithdraw> HistoryWithdraw { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HistoryDeposits>().HasKey(p => p.IdDeposit);
            modelBuilder.Entity<HistoryWithdraw>().HasKey(p => p.IdWithdraw);
        }

    }
}
