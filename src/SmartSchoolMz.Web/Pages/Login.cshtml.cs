using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SmartSchoolMz.Web.Pages;

public class LoginModel : PageModel
{
    [BindProperty]
    public string Role { get; set; } = "Admin";

    public IActionResult OnGet()
    {
        return Page();
    }

    public IActionResult OnPost()
    {
        HttpContext.Session.SetString("UserRole", Role);
        return RedirectToPage("/Dashboard");
    }
}

