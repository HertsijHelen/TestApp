using System.Data.Entity;

namespace TestApp.Entities
{
    public class DataContext: DbContext
    {
        public DataContext()
            : base("DefaultConnection")
        {
        }
        public DbSet<Employee> Employees { get; set; }
    }
}