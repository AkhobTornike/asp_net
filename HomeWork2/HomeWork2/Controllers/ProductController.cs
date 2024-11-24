using HomeWork2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HomeWork2.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            // Fetch products and categories
            var products = ProductList.ProductsList;
            var categories = CategoryList.CategoriesList;

            // Set ViewBag for dynamic content
            ViewBag.Header = "Products For Homework!";

            // Add categories to ViewData for additional display if needed
            ViewData["Categories"] = categories;

            // Add TempData as a Success Message
            TempData["Success"] = "Page Loaded Succesfully";

            return View(products);
        }

        public ActionResult Filter(int? categoryId, decimal? minPrice, decimal? maxPrice)
        {
            var products = ProductList.ProductsList;

            if (categoryId.HasValue)
            {
                products = products.Where(p => p.CategoryId == categoryId.Value).ToList();
            }

            if (minPrice.HasValue)
            {
                products = products.Where(p => p.Price >= minPrice.Value).ToList();
            }

            if (maxPrice.HasValue)
            {
                products = products.Where(p => p.Price <= maxPrice.Value).ToList();
            }

            string categoryName = categoryId.HasValue
                ? CategoryList.CategoriesList.FirstOrDefault(c => c.Id == categoryId.Value)?.Name
                : "All Categories";

            TempData["FilterResult"] = $"{products.Count} products found in {categoryName} category with price range {minPrice:C} to {maxPrice:C}.";

            return View("Index", products);
        }

        public ActionResult Details(int? productId)
        {
            if (!productId.HasValue)
            {
                // Set an error message in TempData
                TempData["Error"] = "No product ID provided.";
                return RedirectToAction("Index");
            }

            // Fetch the specific product by ID
            var product = ProductList.ProductsList.FirstOrDefault(p => p.Id == productId.Value);

            if (product == null)
            {
                // Set an error message in TempData if the product is not found
                TempData["Error"] = "Product not found.";
                return RedirectToAction("Index");
            }

            // Set a success message in TempData
            TempData["Success"] = $"Product '{product.Name}' loaded successfully.";

            // Pass the product as the model to the view
            return View(product);
        }

    }
}
