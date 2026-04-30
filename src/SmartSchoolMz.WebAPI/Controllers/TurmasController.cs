using Microsoft.AspNetCore.Mvc;
using SmartSchoolMz.Application.DTOs;
using SmartSchoolMz.Application.Interfaces;

namespace SmartSchoolMz.WebAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TurmasController : ControllerBase
{
    private readonly ITurmaService _turmaService;

    public TurmasController(ITurmaService turmaService)
    {
        _turmaService = turmaService;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<TurmaDto>>> GetAll()
    {
        return Ok(await _turmaService.GetAllAsync());
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<TurmaDto>> GetById(Guid id)
    {
        var turma = await _turmaService.GetByIdAsync(id);
        if (turma == null) return NotFound();
        return Ok(turma);
    }

    [HttpPost]
    public async Task<ActionResult<TurmaDto>> Create(CreateTurmaDto dto)
    {
        var turma = await _turmaService.CreateAsync(dto);
        return CreatedAtAction(nameof(GetById), new { id = turma.Id }, turma);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(Guid id, UpdateTurmaDto dto)
    {
        await _turmaService.UpdateAsync(id, dto);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        await _turmaService.DeleteAsync(id);
        return NoContent();
    }
}
