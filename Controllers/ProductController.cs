using EdsHikeStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace EdsHikeStore.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult ListProducts()
        {
            var products = ProductData.GetAllProducts(); // Correct method name
            return View(products);
        }

        public IActionResult Detail(int id)
        {
            var product = ProductData.GetProductById(id); // Correct method name
            if (product == null) return NotFound();
            return View(product);
        }
    }
}
