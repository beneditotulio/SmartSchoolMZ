using Microsoft.AspNetCore.Mvc;
using SmartSchoolMz.Application.DTOs;
using SmartSchoolMz.Application.Interfaces;

namespace SmartSchoolMz.WebAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AcademicProcessController : ControllerBase
{
    private readonly IAcademicProcessService _academicProcessService;

    public AcademicProcessController(IAcademicProcessService academicProcessService)
    {
        _academicProcessService = academicProcessService;
    }

    [HttpPost("notas")]
    public async Task<IActionResult> LançarNota(CreateNotaDto dto)
    {
        await _academicProcessService.LançarNotaAsync(dto);
        return Ok(new { message = "Nota lançada com sucesso" });
    }

    [HttpPost("frequencia")]
    public async Task<IActionResult> RegistarFrequencia(CreateFrequenciaDto dto)
    {
        await _academicProcessService.RegistarFrequenciaAsync(dto);
        return Ok(new { message = "Frequência registada com sucesso" });
    }

    [HttpPost("pagamentos")]
    public async Task<IActionResult> RegistarPagamento(CreatePagamentoDto dto)
    {
        await _academicProcessService.RegistarPagamentoAsync(dto);
        return Ok(new { message = "Pagamento registado com sucesso" });
    }
}
