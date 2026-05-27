using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SmartSchoolMz.Web.Pages;

public class LoginModel : PageModel
{
    [BindProperty]
    public string Username { get; set; } = string.Empty;

    [BindProperty]
    public string Password { get; set; } = string.Empty;

    public string? ErrorMessage { get; set; }

    private readonly Dictionary<string, (string Password, string Role)> _mockUsers = new()
    {
        { "admin", ("admin123", "Admin") },
        { "professor", ("professor123", "Professor") },
        { "encarregado", ("encarregado123", "Encarregado") },
        { "aluno", ("aluno123", "Aluno") }
    };

    public IActionResult OnGet()
    {
        return Page();
    }

    public IActionResult OnPost()
    {
        if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password))
        {
            ErrorMessage = "Por favor, preencha todos os campos.";
            return Page();
        }

        if (_mockUsers.TryGetValue(Username.ToLower(), out var user))
        {
            if (user.Password == Password)
            {
                HttpContext.Session.SetString("UserRole", user.Role);
                HttpContext.Session.SetString("Username", Username);
                return RedirectToPage("/Dashboard");
            }
        }

        ErrorMessage = "Nome de utilizador ou senha incorretos.";
        return Page();
    }
}

