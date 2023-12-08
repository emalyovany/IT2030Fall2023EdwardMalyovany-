using EdsHikeStore.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace EdsHikeStore.Pages.Product
{
    public class ListProductsModel : PageModel
    {
        // Initialize the Products property with an empty list to ensure it's never null
        public List<ProductModel> Products { get; private set; } = new List<ProductModel>();

        public void OnGet()
        {
            Products = ProductData.GetAllProducts(); // Assuming GetAllProducts() returns a List<ProductModel>
        }
    }
}
