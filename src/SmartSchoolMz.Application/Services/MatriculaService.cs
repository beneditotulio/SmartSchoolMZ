using Microsoft.EntityFrameworkCore;
using SmartSchoolMz.Application.DTOs;
using SmartSchoolMz.Application.Interfaces;
using SmartSchoolMz.Domain.Entities;
using SmartSchoolMz.Domain.Interfaces;

namespace SmartSchoolMz.Application.Services;

public class MatriculaService : IMatriculaService
{
    private readonly IRepository<Matricula> _matriculaRepository;

    public MatriculaService(IRepository<Matricula> matriculaRepository)
    {
        _matriculaRepository = matriculaRepository;
    }

    public async Task<IEnumerable<MatriculaDto>> GetAllAsync()
    {
        var matriculas = await _matriculaRepository.Query()
            .Include(m => m.Aluno)
            .Include(m => m.Turma)
            .Include(m => m.AnoLetivo)
            .ToListAsync();

        return matriculas.Select(m => new MatriculaDto(
            m.Id,
            m.AlunoId,
            m.Aluno.NomeCompleto,
            m.TurmaId,
            m.Turma.Nome,
            m.AnoLetivoId,
            m.AnoLetivo.Ano,
            m.DataMatricula,
            m.Estado
        ));
    }

    public async Task<MatriculaDto?> GetByIdAsync(Guid id)
    {
        var m = await _matriculaRepository.Query()
            .Include(m => m.Aluno)
            .Include(m => m.Turma)
            .Include(m => m.AnoLetivo)
            .FirstOrDefaultAsync(x => x.Id == id);

        return m != null ? new MatriculaDto(
            m.Id,
            m.AlunoId,
            m.Aluno.NomeCompleto,
            m.TurmaId,
            m.Turma.Nome,
            m.AnoLetivoId,
            m.AnoLetivo.Ano,
            m.DataMatricula,
            m.Estado
        ) : null;
    }

    public async Task<MatriculaDto> CreateAsync(CreateMatriculaDto dto)
    {
        var matricula = new Matricula
        {
            AlunoId = dto.AlunoId,
            TurmaId = dto.TurmaId,
            AnoLetivoId = dto.AnoLetivoId,
            DataMatricula = DateTime.UtcNow
        };

        await _matriculaRepository.AddAsync(matricula);
        await _matriculaRepository.SaveChangesAsync();

        return (await GetByIdAsync(matricula.Id))!;
    }

    public async Task UpdateEstadoAsync(Guid id, UpdateMatriculaEstadoDto dto)
    {
        var matricula = await _matriculaRepository.GetByIdAsync(id);
        if (matricula == null) return;

        matricula.Estado = dto.Estado;
        matricula.UpdatedAt = DateTime.UtcNow;

        _matriculaRepository.Update(matricula);
        await _matriculaRepository.SaveChangesAsync();
    }
}
