using Microsoft.EntityFrameworkCore;

namespace GeekShopping.ProductAPI.Model.Context
{
    public class SqlServercontext: DbContext
    {
        public SqlServercontext(){}

        public SqlServercontext(DbContextOptions<SqlServercontext> options): base(options) { }

        public DbSet<Product> Products { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 4,
                    Name = "Nome do produto teste",
                    Description = "Teste de descrição",
                    Price = new decimal(69.9),
                    ImageUrl = "https://teste.png",
                    CategoryName = "Teste"
                }
            );
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 5,
                    Name = "Nome do produto teste 5",
                    Description = "Teste de descrição 5",
                    Price = new decimal(89.9),
                    ImageUrl = "https://teste5.png",
                    CategoryName = "Teste"
                }
            );
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 6,
                    Name = "Nome do produto teste 6",
                    Description = "Teste de descrição 6",
                    Price = new decimal(43.4),
                    ImageUrl = "https://teste6.png",
                    CategoryName = "Teste"
                }
            );
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 7,
                    Name = "Nome do produto teste 7",
                    Description = "Teste de descrição 7",
                    Price = new decimal(15.9),
                    ImageUrl = "https://teste7.png",
                    CategoryName = "Teste"
                }
            );
        }
    }
}
