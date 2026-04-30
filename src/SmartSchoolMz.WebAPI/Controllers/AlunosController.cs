using Microsoft.AspNetCore.Mvc;
using SmartSchoolMz.Application.DTOs;
using SmartSchoolMz.Application.Interfaces;

namespace SmartSchoolMz.WebAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AlunosController : ControllerBase
{
    private readonly IAlunoService _alunoService;

    public AlunosController(IAlunoService alunoService)
    {
        _alunoService = alunoService;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<AlunoDto>>> GetAll()
    {
        return Ok(await _alunoService.GetAllAsync());
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<AlunoDto>> GetById(Guid id)
    {
        var aluno = await _alunoService.GetByIdAsync(id);
        if (aluno == null) return NotFound();
        return Ok(aluno);
    }

    [HttpPost]
    public async Task<ActionResult<AlunoDto>> Create(CreateAlunoDto dto)
    {
        var aluno = await _alunoService.CreateAsync(dto);
        return CreatedAtAction(nameof(GetById), new { id = aluno.Id }, aluno);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(Guid id, UpdateAlunoDto dto)
    {
        await _alunoService.UpdateAsync(id, dto);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        await _alunoService.DeleteAsync(id);
        return NoContent();
    }
}
