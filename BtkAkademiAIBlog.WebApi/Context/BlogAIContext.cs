using BtkAkademiAIBlog.WebApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace BtkAkademiAIBlog.WebApi.Context
{
    public class BlogAIContext : DbContext
    {
        public BlogAIContext(DbContextOptions<BlogAIContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
