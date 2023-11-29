using Microsoft.EntityFrameworkCore;

namespace BookShopMVC.Models.EntityFramework
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Define DbSets here. For example:
        public DbSet<Book> Books { get; set; }
    }
}
