using Dashboard.Domain.Entities;
using System.Data.Entity;

namespace Dashboard.Domain.Concrete
{
    public class EFDbContext : DbContext
    {
        public DbSet<HealthBoard> Products { get; set; }
    }
}