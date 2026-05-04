using Microsoft.AspNetCore.Mvc.RazorPages;
using SmartSchoolMz.Application.DTOs;
using SmartSchoolMz.Application.Interfaces;

namespace SmartSchoolMz.Web.Pages.Matriculas;

public class IndexModel : PageModel
{
    private readonly IMatriculaService _matriculaService;

    public IndexModel(IMatriculaService matriculaService)
    {
        _matriculaService = matriculaService;
    }

    public IEnumerable<MatriculaDto> Matriculas { get; set; } = new List<MatriculaDto>();

    public async Task OnGetAsync()
    {
        Matriculas = await _matriculaService.GetAllAsync();
    }
}
