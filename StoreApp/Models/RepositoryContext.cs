using Microsoft.EntityFrameworkCore;

namespace StoreApp.Models
{
    public class RepositoryContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public RepositoryContext(DbContextOptions<RepositoryContext> options)
        : base(options)
        {

        }

        //DbContext'in bazı metotlarını geçersiz kılmak için
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>()
            .HasData(
                new Product() { ProductId = 1, ProductName = "Sweatshirt", Price = 500 },
                new Product() { ProductId = 2, ProductName = "T-shirt", Price = 400 },
                new Product() { ProductId = 3, ProductName = "Pants", Price = 700 },
                new Product() { ProductId = 4, ProductName = "Cardigan", Price = 1000 },
                new Product() { ProductId = 5, ProductName = "Shoes", Price = 3000 }
            );
        }
    }
}