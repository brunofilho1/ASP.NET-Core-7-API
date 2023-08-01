using Microsoft.EntityFrameworkCore;
using PrimeiraAPI.Domain.Model;

namespace PrimeiraAPI.Infrastructure.Repositories
{
    public class ConnectionContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Infrastructure/PrimeiraApiDatabase.db");
        }
    }
}
