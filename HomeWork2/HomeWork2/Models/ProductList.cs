using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeWork2.Models
{
    public class ProductList
    {
        public static List<Product> ProductsList = new List<Product>()
        {
            new Product
            {
                Id = 1,
                Name = "Laptop",
                Price = 999.99m,
                Description = "A high-performance laptop",
                CategoryId = 1
            },
            new Product
            {
                Id = 2,
                Name = "Smartphone",
                Price = 599.99m,
                Description = "A powerful smartphone",
                CategoryId = 2
            },
            new Product
            {
                Id = 3,
                Name = "Headphones",
                Price = 199.99m,
                Description = "Noise-canceling headphones",
                CategoryId = 3
            },
            new Product
            {
                Id = 4,
                Name = "Smartwatch",
                Price = 149.99m,
                Description = "A stylish smartwatch",
                CategoryId = 2
            },
            new Product
            {
                Id = 5,
                Name = "Tablet",
                Price = 299.99m,
                Description = "A lightweight tablet",
                CategoryId = 1
            },
            new Product
            {
                Id = 6,
                Name = "Gaming Mouse",
                Price = 49.99m,
                Description = "Ergonomic gaming mouse",
                CategoryId = 4
            },
            new Product
            {
                Id = 7,
                Name = "Keyboard",
                Price = 79.99m,
                Description = "Mechanical keyboard",
                CategoryId = 4
            },
            new Product
            {
                Id = 8,
                Name = "Monitor",
                Price = 249.99m,
                Description = "24-inch Full HD monitor",
                CategoryId = 5
            },
            new Product
            {
                Id = 9,
                Name = "External Hard Drive",
                Price = 89.99m,
                Description = "1TB portable hard drive",
                CategoryId = 6
            },
            new Product
            {
                Id = 10,
                Name = "Bluetooth Speaker",
                Price = 129.99m,
                Description = "Portable Bluetooth speaker",
                CategoryId = 3
            }
        };
    }
}
