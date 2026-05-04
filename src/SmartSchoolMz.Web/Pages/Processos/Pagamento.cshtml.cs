using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SmartSchoolMz.Application.DTOs;
using SmartSchoolMz.Application.Interfaces;

namespace SmartSchoolMz.Web.Pages.Processos;

public class PagamentoModel : PageModel
{
    private readonly IAcademicProcessService _academicService;
    private readonly IMatriculaService _matriculaService;

    public PagamentoModel(IAcademicProcessService academicService, IMatriculaService matriculaService)
    {
        _academicService = academicService;
        _matriculaService = matriculaService;
    }

    [BindProperty]
    public CreatePagamentoDto Input { get; set; } = default!;

    public MatriculaDto? Matricula { get; set; }

    public async Task<IActionResult> OnGetAsync(Guid id)
    {
        Matricula = await _matriculaService.GetByIdAsync(id);
        if (Matricula == null) return NotFound();

        Input = new CreatePagamentoDto(id, DateTime.Now.ToString("MMMM"), DateTime.Now.Year, 0, Domain.Enums.MetodoPagamento.Numerario, null);
        return Page();
    }

    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        await _academicService.RegistarPagamentoAsync(Input);
        return RedirectToPage("/Matriculas/Index");
    }
}
