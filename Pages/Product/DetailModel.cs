using EdsHikeStore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EdsHikeStore.Pages.Product
{
    public class DetailModel : PageModel
    {
        // Using the nullable reference type here to handle the case where the product might not be found
        public ProductModel? Product { get; set; }

        public IActionResult OnGet(int productId)
        {
            Product = ProductData.GetProductById(productId);
            if (Product == null)
            {
                // Redirect to a Not Found page or return a NotFound result
                return NotFound();
            }
            return Page();
        }
    }
}
