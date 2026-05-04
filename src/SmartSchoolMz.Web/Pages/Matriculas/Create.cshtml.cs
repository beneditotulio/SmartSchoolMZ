using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SmartSchoolMz.Application.DTOs;
using SmartSchoolMz.Application.Interfaces;
using SmartSchoolMz.Domain.Entities;
using SmartSchoolMz.Domain.Interfaces;

namespace SmartSchoolMz.Web.Pages.Matriculas;

public class CreateModel : PageModel
{
    private readonly IMatriculaService _matriculaService;
    private readonly IAlunoService _alunoService;
    private readonly ITurmaService _turmaService;
    private readonly IRepository<AnoLetivo> _anoLetivoRepo;

    public CreateModel(
        IMatriculaService matriculaService,
        IAlunoService alunoService,
        ITurmaService turmaService,
        IRepository<AnoLetivo> anoLetivoRepo)
    {
        _matriculaService = matriculaService;
        _alunoService = alunoService;
        _turmaService = turmaService;
        _anoLetivoRepo = anoLetivoRepo;
    }

    [BindProperty]
    public CreateMatriculaDto Input { get; set; } = default!;

    public SelectList Alunos { get; set; } = default!;
    public SelectList Turmas { get; set; } = default!;
    public SelectList AnosLetivos { get; set; } = default!;

    public async Task OnGetAsync()
    {
        var alunos = await _alunoService.GetAllAsync();
        var turmas = await _turmaService.GetAllAsync();
        var anos = await _anoLetivoRepo.GetAllAsync();

        Alunos = new SelectList(alunos, "Id", "NomeCompleto");
        Turmas = new SelectList(turmas, "Id", "Nome");
        AnosLetivos = new SelectList(anos, "Id", "Ano");
    }

    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
        {
            await OnGetAsync();
            return Page();
        }

        await _matriculaService.CreateAsync(Input);
        return RedirectToPage("./Index");
    }
}
