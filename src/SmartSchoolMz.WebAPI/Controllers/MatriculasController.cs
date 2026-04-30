using Microsoft.AspNetCore.Mvc;
using SmartSchoolMz.Application.DTOs;
using SmartSchoolMz.Application.Interfaces;

namespace SmartSchoolMz.WebAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MatriculasController : ControllerBase
{
    private readonly IMatriculaService _matriculaService;

    public MatriculasController(IMatriculaService matriculaService)
    {
        _matriculaService = matriculaService;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<MatriculaDto>>> GetAll()
    {
        return Ok(await _matriculaService.GetAllAsync());
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<MatriculaDto>> GetById(Guid id)
    {
        var matricula = await _matriculaService.GetByIdAsync(id);
        if (matricula == null) return NotFound();
        return Ok(matricula);
    }

    [HttpPost]
    public async Task<ActionResult<MatriculaDto>> Create(CreateMatriculaDto dto)
    {
        var matricula = await _matriculaService.CreateAsync(dto);
        return CreatedAtAction(nameof(GetById), new { id = matricula.Id }, matricula);
    }

    [HttpPatch("{id}/estado")]
    public async Task<IActionResult> UpdateEstado(Guid id, UpdateMatriculaEstadoDto dto)
    {
        await _matriculaService.UpdateEstadoAsync(id, dto);
        return NoContent();
    }
}
