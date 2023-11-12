using Microsoft.AspNetCore.Mvc;
using EdsHikeStore.Models;

namespace EdsHikeStore.Controllers
{
    public class ContactController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

        [HttpPost]
        public IActionResult Index(ContactModel model)
        {
            if (ModelState.IsValid)
            {
                // Handle the form submission...
                return View("Success"); // Redirect to a success view if needed
            }

            return View(model);
        }
    }
}
