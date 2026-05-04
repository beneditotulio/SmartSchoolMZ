using Microsoft.AspNetCore.Mvc.RazorPages;
using SmartSchoolMz.Application.DTOs;
using SmartSchoolMz.Application.Interfaces;

namespace SmartSchoolMz.Web.Pages.Alunos;

public class IndexModel : PageModel
{
    private readonly IAlunoService _alunoService;

    public IndexModel(IAlunoService alunoService)
    {
        _alunoService = alunoService;
    }

    public IEnumerable<AlunoDto> Alunos { get; set; } = new List<AlunoDto>();

    public async Task OnGetAsync()
    {
        Alunos = await _alunoService.GetAllAsync();
    }
}
