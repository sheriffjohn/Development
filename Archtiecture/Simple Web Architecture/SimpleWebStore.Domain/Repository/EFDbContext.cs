using SimpleWebStore.Domain.Entities;
using System.Data.Entity;

namespace SimpleWebStore.Domain.Concrete
{
    public class EFDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}
