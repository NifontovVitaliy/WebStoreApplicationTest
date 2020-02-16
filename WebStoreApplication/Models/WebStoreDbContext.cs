using Microsoft.EntityFrameworkCore;

namespace WebStoreApplication.Models
{
    public class WebStoreDbContext : DbContext
    {
        public WebStoreDbContext(DbContextOptions<WebStoreDbContext> options) : base(options){}
        public DbSet<Phone> Phones { get; set; }
        public DbSet<Company> Companies { get; set; }
    }
}
