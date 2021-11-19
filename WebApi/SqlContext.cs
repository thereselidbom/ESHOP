using Microsoft.EntityFrameworkCore;
using WebApi.Models;

namespace WebApi
{
    public class SqlContext : DbContext
    {
        public SqlContext(DbContextOptions<SqlContext> options) : base(options)
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<SubCategory> SubCategories { get; set; }
        public virtual DbSet<Product> Products { get; set; }

        public virtual DbSet<User> Users { get; set; }


    }
}
