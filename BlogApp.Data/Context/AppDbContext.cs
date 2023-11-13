using BlogApp.Entity.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlogApp.Data.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Article> Articles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Article> Artcicles { get; set; }

    }
}
