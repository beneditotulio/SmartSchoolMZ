using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SmartSchoolMz.Web.Pages;

public class DashboardModel : PageModel
{
    public string UserRole { get; private set; } = string.Empty;

    public IActionResult OnGet()
    {
        UserRole = HttpContext.Session.GetString("UserRole") ?? string.Empty;
        
        if (string.IsNullOrEmpty(UserRole))
        {
            return RedirectToPage("/Login");
        }
        
        return Page();
    }
}

