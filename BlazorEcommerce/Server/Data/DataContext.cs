using Microsoft.EntityFrameworkCore;
namespace BlazorEcommerce.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "Galaxy",
                    Description = "stars weekend trawis scott",
                    ImageUrl = "https://avatars.mds.yandex.net/i?id=69ebc3194bc39fbd68a48e92eb6e1e6caddfdcca-9236004-images-thumbs&n=13",
                    Price = 9.99m
                },
                new Product
                {
                    Id = 2,
                    Title = "House",
                    Description = "House house house man car",
                    ImageUrl = "https://avatars.mds.yandex.net/i?id=7be6729fc150193c06bf0c61840bff798ae2ab62-9152303-images-thumbs&n=13",
                    Price = 8.99m
                },
                new Product
                {
                    Id = 3,
                    Title = "Marginal",
                    Description = "lorem ipsum",
                    ImageUrl = "https://avatars.mds.yandex.net/i?id=7fe5fc045d852fd08454e9bdda42ce1c41f21cc7-9035616-images-thumbs&n=13",
                    Price = 7.99m
                }
                );
        }

        public DbSet<Product> Products { get; set; } // создание таблицы в БД со свойствами модели Product
    }
}
