using A1.Models;
using Microsoft.EntityFrameworkCore;
namespace A1.Data
{
    public class A1DbContext : DbContext
    {
        public A1DbContext(DbContextOptions<A1DbContext> options) : base(options) { }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=A1Database.sqlite");
        }
    }
}
