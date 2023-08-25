using ExpenseTracker.Models;
using Microsoft.EntityFrameworkCore;

namespace ExpenseTracker.DbCon
{
    public class DBConContext:DbContext
    {
        public DBConContext(DbContextOptions<DBConContext> options) : base(options) { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Expense> Expenses { get; set; }

    }
}
