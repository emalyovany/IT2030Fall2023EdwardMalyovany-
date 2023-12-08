using System.Collections.Generic;
using System.Linq;

namespace EdsHikeStore.Models
{
    public static class ProductData
    {
        // Mock in-memory data store
        private static readonly List<ProductModel> _products = new List<ProductModel>
        {
            new ProductModel { ProductId = 1, ProductName = "Hiking Socks", ProductDescription = "Anti Blister Hiking Socks (2 PACK)", ProductImage = "/images/hikingsocks.jfif", ProductPrice = 19.99m },
            new ProductModel { ProductId = 2, ProductName = "Boots", ProductDescription = "Water Resistant Hiking Boots", ProductImage = "/images/hikingboots.jpg", ProductPrice = 89.99m },
            new ProductModel { ProductId = 3, ProductName = "Coat", ProductDescription = "Waterproof Hiking Coat", ProductImage = "/images/hikingcoat.jpg", ProductPrice = 89.99m },
            new ProductModel { ProductId = 4, ProductName = "Gloves", ProductDescription = "Artic Hiking Gloves", ProductImage = "/images/gloves.jpg", ProductPrice = 19.99m },
            new ProductModel { ProductId = 5, ProductName = "Hiking Bag", ProductDescription = "50L Hiking Backpack", ProductImage = "/images/backpack.webp", ProductPrice = 119.99m },
            new ProductModel { ProductId = 6, ProductName = "Trekking Poles", ProductDescription = "Carbon Trekking Poles", ProductImage = "/images/poles.jfif", ProductPrice = 89.99m }
        };

        // Method to retrieve all products
        public static List<ProductModel> GetAllProducts()
        {
            return _products;
        }

        // Method to retrieve a single product by ID
        public static ProductModel GetProductById(int id)
        {
            return _products.FirstOrDefault(p => p.ProductId == id);
        }
    }
}
