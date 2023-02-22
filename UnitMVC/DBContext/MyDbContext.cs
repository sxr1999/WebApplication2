using Microsoft.EntityFrameworkCore;
using UnitMVC.Models;

namespace UnitMVC.DBContext
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {

        }

        public DbSet<Book>  books { get; set; }
    }
}
