using Haushaltsbuch.Entities;
using Microsoft.EntityFrameworkCore;

namespace Haushaltsbuch
{
    public class BudgetBookContext : DbContext
    {
        public BudgetBookContext(DbContextOptions<BudgetBookContext> options)
            : base(options)
        {

        }
        public DbSet<Income>? Incomes { get; set; }
        public DbSet<Expense>? Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Host=localhost;Database=testDataBase;Username=my_user;Password=my_pw");
    }
}
