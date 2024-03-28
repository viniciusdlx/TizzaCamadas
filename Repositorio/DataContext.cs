using Microsoft.EntityFrameworkCore;

namespace Repositorio
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // modelBuilder.Entity<Pizzaria>().HasKey(p => p.Id);
            base.OnModelCreating(modelBuilder);
        }

    }
}