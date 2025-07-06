using System.Collections.Generic;
using System.Linq;

namespace ECommerceApp.Services
{
    public class ProductService
    {
        private readonly List<Product> products = new()
        {
            new Product { Id = 1, Name = "Red Ankle Boots", Price = 59.99M, ImageUrl = "images/H1.jpg", Description = "Stylish and comfortable ankle boots." },
            new Product { Id = 2, Name = "Glitter Sequins", Price = 9487.0M, ImageUrl = "images/H2.jpg", Description = "Luxury glitter sequin heels." },
            new Product { Id = 3, Name = "Double Bow Heels", Price = 2900.00M, ImageUrl = "images/H3.jpg", Description = "Elegant bow-styled heels." },
            new Product { Id = 4, Name = "Siletto Diamond Heels", Price = 67.99M, ImageUrl = "images/H5.jpg", Description = "Shiny diamond-embedded stilettos." },
            new Product { Id = 5, Name = "Butterfly Suede Sandals", Price = 67.99M, ImageUrl = "images/H6.jpg", Description = "Suede sandals with butterfly details." },
            new Product { Id = 6, Name = "Crystal Strap Pumps", Price = 67.99M, ImageUrl = "images/H11.jpg", Description = "Elegant pumps with crystal straps." },
            new Product { Id = 7, Name = "Suede Black Boots", Price = 67.99M, ImageUrl = "images/H12.jpg", Description = "Classic black suede boots." },
            new Product { Id = 8, Name = "Crystal Shoe", Price = 67.99M, ImageUrl = "images/H13.jpg", Description = "Transparent crystal-styled heels." },
            new Product { Id = 9, Name = "Vanessa Heels", Price = 67.99M, ImageUrl = "images/H14.jpg", Description = "Sophisticated high heels for special occasions." },
            new Product { Id = 10, Name = "Leather Pumps", Price = 67.99M, ImageUrl = "images/H15.jpg", Description = "Classic leather pumps for a chic look." },
            new Product { Id = 11, Name = "Alexander Wang Heels", Price = 67.99M, ImageUrl = "images/H16.jpg", Description = "Designer heels by Alexander Wang." },
            new Product { Id = 12, Name = "Mesh Body Heels", Price = 67.99M, ImageUrl = "images/H4.jpg", Description = "High heels with a modern mesh design." },
            new Product { Id = 13, Name = "YSL Opyum Heels", Price = 67.99M, ImageUrl = "images/H7.jpg", Description = "Iconic YSL Opyum heels with a bold design." },
            new Product { Id = 14, Name = "Plush Stiletto", Price = 67.99M, ImageUrl = "images/H8.jpg", Description = "Luxurious plush stiletto heels." },
            new Product { Id = 15, Name = "YSL Monogram Heels", Price = 67.99M, ImageUrl = "images/H9.jpg", Description = "Elegant YSL monogram-styled heels." },
            new Product { Id = 16, Name = "Saint Laurent Heels", Price = 67.99M, ImageUrl = "images/H10.jpg", Description = "Premium Saint Laurent designer heels." }
        };

        public List<Product> GetProducts() => products;
        public Product GetProductById(int id) => products.FirstOrDefault(p => p.Id == id);
    }

    public class Product 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
    }
}
