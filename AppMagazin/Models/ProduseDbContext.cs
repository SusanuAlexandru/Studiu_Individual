using Microsoft.EntityFrameworkCore;

namespace AppMagazin.Models
{
    public class ProduseDbContext : DbContext
    {
        public DbSet<Produs> Produsele { get; set; }
        public ProduseDbContext(DbContextOptions<ProduseDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
