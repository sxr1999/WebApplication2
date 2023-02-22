using Microsoft.EntityFrameworkCore;

namespace WebApplication2
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Article> Article { get; set; }
        public DbSet<ArticleCategories> ArticleCategories { get; set; }
    }
}
