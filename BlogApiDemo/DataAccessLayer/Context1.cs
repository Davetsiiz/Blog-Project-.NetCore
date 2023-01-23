using Microsoft.EntityFrameworkCore;

namespace BlogApiDemo.DataAccessLayer
{
    public class Context1:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-HKAH8F2;Initial Catalog=CoreKampApiDB;Integrated Security=True");
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
