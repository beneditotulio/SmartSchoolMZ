using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SmartSchoolMz.Web.Pages;

public class DashboardModel : PageModel
{
    public string UserRole { get; private set; } = string.Empty;

    public void OnGet()
    {
        UserRole = HttpContext.Session.GetString("UserRole") ?? "Admin";
    }
}

