using Microsoft.AspNetCore.Mvc.RazorPages;
using SmartSchoolMz.Application.DTOs;
using SmartSchoolMz.Application.Interfaces;

namespace SmartSchoolMz.Web.Pages.Turmas;

public class IndexModel : PageModel
{
    private readonly ITurmaService _turmaService;

    public IndexModel(ITurmaService turmaService)
    {
        _turmaService = turmaService;
    }

    public IEnumerable<TurmaDto> Turmas { get; set; } = new List<TurmaDto>();

    public async Task OnGetAsync()
    {
        Turmas = await _turmaService.GetAllAsync();
    }
}
