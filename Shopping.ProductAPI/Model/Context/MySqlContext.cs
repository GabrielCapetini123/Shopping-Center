using Microsoft.EntityFrameworkCore;

namespace Shopping.ProductAPI.Model.Context
{
    public class MySqlContext : DbContext
    {
        public MySqlContext() { }
        public MySqlContext(DbContextOptions<MySqlContext> options) : base(options) { }
        public DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 3,
                Name = "Camiseta Nike Preta",
                Price = new decimal(69.99),
                Description = "Camiseta da Nike em 100% algodão",
                ImageUrl = "https://imgnike-a.akamaihd.net/1920x1920/016388IE.jpg",
                CategoryName = "T-shirt"

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 4,
                Name = "Camiseta Adidas Preta",
                Price = new decimal(69.99),
                Description = "Camiseta da Adidas em 100% algodão",
                ImageUrl = "https://gaston.vteximg.com.br/arquivos/ids/337744-420-420/2001155676_Ampliada.jpg?v=638035987668800000",
                CategoryName = "T-shirt"

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 5,
                Name = "Camiseta Hering",
                Price = new decimal(69.99),
                Description = "Camiseta da Hering em 100% algodão",
                ImageUrl = "https://imgnike-a.akamaihd.net/1920x1920/016388IE.jpg",
                CategoryName = "T-shirt"

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 6,
                Name = "Camiseta Nike Branca",
                Price = new decimal(69.99),
                Description = "Camiseta da Nike em 100% algodão",
                ImageUrl = "https://cdn.dooca.store/946/products/c4lgbuzwcmrcemhzmsfxymisccwvok0cwhod.jpg?v=1658773028&webp=0",
                CategoryName = "T-shirt"

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 7,
                Name = "Camiseta Adidas Branca",
                Price = new decimal(69.99),
                Description = "Camiseta da Adidas em 100% algodão",
                ImageUrl = "https://centralsurf.vteximg.com.br/arquivos/ids/313815-1000-1000/Camiseta-Adidas-Logo-0.jpg?v=637387355630500000",
                CategoryName = "T-shirt"

            });
        }
    }
}
