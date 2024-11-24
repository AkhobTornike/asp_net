using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeWork2.Models
{
    public class CategoryList
    {
        public static List<Category> CategoriesList = new List<Category>()
        {
            new Category
            {
                Id = 1,
                Name = "Electronics"
            },
            new Category
            {
                Id = 2,
                Name = "Mobile Devices"
            },
            new Category
            {
                Id = 3,
                Name = "Audio Equipment"
            },
            new Category
            {
                Id = 4,
                Name = "Computer Accessories"
            },
            new Category
            {
                Id = 5,
                Name = "Displays"
            },
            new Category
            {
                Id = 6,
                Name = "Storage Devices"
            },
            new Category
            {
                Id = 7,
                Name = "Home Appliances"
            },
            new Category
            {
                Id = 8,
                Name = "Gaming"
            },
            new Category
            {
                Id = 9,
                Name = "Wearables"
            },
            new Category
            {
                Id = 10,
                Name = "Networking"
            }
        };
    }
}
