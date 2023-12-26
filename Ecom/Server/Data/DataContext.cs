namespace Ecom.Server.Data
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
                    Title = "Roshen Sweet Dark Chocolate Bar",
                    Description = "Sweet tooth: For those who enjoy sweet delicacies so much that they cannot make themselves stop until a whole table of chocolate is gone, this is a must try!",
                    ImageUrl = "https://m.media-amazon.com/images/W/MEDIAX_792452-T2/images/I/51BgFiH0PlL._SL1031_.jpg",
                    Price = 16.99m,
                },
                new Product
                {
                    Id = 2,
                    Title = "Ferrero Rocher Collection",
                    Description = "Premium Gourmet Assorted Hazelnut Milk Chocolate, Dark Chocolate And Coconut Chocolates, Luxury Chocolate Holiday Gift Box",
                    ImageUrl = "https://m.media-amazon.com/images/W/MEDIAX_792452-T2/images/I/918H0O3KDNL._SL1500_.jpg",
                    Price = 37.99m,
                },
                new Product
                {
                    Id = 3,
                    Title = "Kinder Bueno",
                    Description = "Kinder Bueno is a crispy, creamy, and delicious chocolate bar an unexpected combination of tastes and textures",
                    ImageUrl = "https://m.media-amazon.com/images/W/MEDIAX_792452-T2/images/I/61g32E3y7dL._SL1500_.jpg",
                    Price = 3.49m,
                }
                );
        }

        public DbSet<Product> Products { get; set; }
    }
}
