using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EdsHikeStore.Pages;

public class ContactModel : PageModel
{
    private readonly ILogger<ContactModel> _logger;

    // Add properties for your contact form here
    // ...

    public ContactModel(ILogger<ContactModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        // Logic to execute when the page is accessed
    }

    // If you're planning to handle form submissions, add an OnPost method
    // public void OnPost()
    // {
    //     // Handle form submission
    // }
}
