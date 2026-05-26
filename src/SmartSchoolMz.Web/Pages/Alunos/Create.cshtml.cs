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
        Input = new CreateAlunoDto
        {
            NomeCompleto = "",
            DataNascimento = DateTime.Today.AddYears(-6),
            Sexo = Domain.Enums.Sexo.Masculino,
            DocumentoIdentificacao = "",
            NumeroMatricula = "",
            Morada = "",
            Contacto = "",
            Email = null,
            DataIngresso = DateTime.Today
        };
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
