using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SmartSchoolMz.Application.DTOs;
using SmartSchoolMz.Application.Interfaces;

namespace SmartSchoolMz.Web.Pages.Alunos;

public class CreateModel : PageModel
{
    private readonly IAlunoService _alunoService;

    public CreateModel(IAlunoService alunoService)
    {
        _alunoService = alunoService;
    }

    [BindProperty]
    public CreateAlunoDto Input { get; set; } = default!;

    public void OnGet()
    {
        Input = new CreateAlunoDto(
            "", DateTime.Today.AddYears(-6), Domain.Enums.Sexo.Masculino, "", "", "", "", null, DateTime.Today
        );
    }

    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        await _alunoService.CreateAsync(Input);
        return RedirectToPage("./Index");
    }
}
