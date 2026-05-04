using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SmartSchoolMz.Application.DTOs;
using SmartSchoolMz.Application.Interfaces;
using SmartSchoolMz.Domain.Entities;
using SmartSchoolMz.Domain.Interfaces;

namespace SmartSchoolMz.Web.Pages.Turmas;

public class CreateModel : PageModel
{
    private readonly ITurmaService _turmaService;
    private readonly IRepository<Classe> _classeRepo;
    private readonly IRepository<AnoLetivo> _anoLetivoRepo;

    public CreateModel(ITurmaService turmaService, IRepository<Classe> classeRepo, IRepository<AnoLetivo> anoLetivoRepo)
    {
        _turmaService = turmaService;
        _classeRepo = classeRepo;
        _anoLetivoRepo = anoLetivoRepo;
    }

    [BindProperty]
    public CreateTurmaDto Input { get; set; } = default!;

    public SelectList Classes { get; set; } = default!;
    public SelectList AnosLetivos { get; set; } = default!;

    public async Task OnGetAsync()
    {
        var classes = await _classeRepo.GetAllAsync();
        var anos = await _anoLetivoRepo.GetAllAsync();

        Classes = new SelectList(classes, "Id", "Nome");
        AnosLetivos = new SelectList(anos, "Id", "Ano");
    }

    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
        {
            await OnGetAsync();
            return Page();
        }

        await _turmaService.CreateAsync(Input);
        return RedirectToPage("./Index");
    }
}
