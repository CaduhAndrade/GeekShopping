using Microsoft.EntityFrameworkCore;

namespace GeekShopping.API.Model.Context
{
    public class MySqlContext : DbContext
    {
        public MySqlContext()
        { }
        public MySqlContext(DbContextOptions<MySqlContext> options) : base(options)
        { }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 1,
                Name = "Name",
                Price = new decimal(56.5),
                Description = "oaisdaoisdjaiosjdasoid",
                ImageUrl = "www.google.com.br",
                CategoryName = "T-shirt"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 2,
                Name = "Name",
                Price = new decimal(56.5),
                Description = "oaisdaoisdjaiosjdasoid",
                ImageUrl = "www.google.com.br",
                CategoryName = "T-shirt"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 3,
                Name = "Name",
                Price = new decimal(56.5),
                Description = "oaisdaoisdjaiosjdasoid",
                ImageUrl = "www.google.com.br",
                CategoryName = "T-shirt"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 4,
                Name = "Name",
                Price = new decimal(56.5),
                Description = "oaisdaoisdjaiosjdasoid",
                ImageUrl = "www.google.com.br",
                CategoryName = "T-shirt"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 5,
                Name = "Name",
                Price = new decimal(56.5),
                Description = "oaisdaoisdjaiosjdasoid",
                ImageUrl = "www.google.com.br",
                CategoryName = "T-shirt"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 6,
                Name = "Name",
                Price = new decimal(56.5),
                Description = "oaisdaoisdjaiosjdasoid",
                ImageUrl = "www.google.com.br",
                CategoryName = "T-shirt"
            });
        }
    }
}
