using Microsoft.EntityFrameworkCore;
using SmartSchoolMz.Application.DTOs;
using SmartSchoolMz.Application.Interfaces;
using SmartSchoolMz.Domain.Entities;
using SmartSchoolMz.Domain.Interfaces;

namespace SmartSchoolMz.Application.Services;

public class TurmaService : ITurmaService
{
    private readonly IRepository<Turma> _turmaRepository;

    public TurmaService(IRepository<Turma> turmaRepository)
    {
        _turmaRepository = turmaRepository;
    }

    public async Task<IEnumerable<TurmaDto>> GetAllAsync()
    {
        var turmas = await _turmaRepository.Query()
            .Include(t => t.Classe)
            .Include(t => t.AnoLetivo)
            .ToListAsync();

        return turmas.Select(t => new TurmaDto(
            t.Id,
            t.Nome,
            t.ClasseId,
            t.Classe.Nome,
            t.AnoLetivoId,
            t.AnoLetivo.Ano
        ));
    }

    public async Task<TurmaDto?> GetByIdAsync(Guid id)
    {
        var t = await _turmaRepository.Query()
            .Include(t => t.Classe)
            .Include(t => t.AnoLetivo)
            .FirstOrDefaultAsync(x => x.Id == id);

        return t != null ? new TurmaDto(
            t.Id,
            t.Nome,
            t.ClasseId,
            t.Classe.Nome,
            t.AnoLetivoId,
            t.AnoLetivo.Ano
        ) : null;
    }

    public async Task<TurmaDto> CreateAsync(CreateTurmaDto dto)
    {
        var turma = new Turma
        {
            Nome = dto.Nome,
            ClasseId = dto.ClasseId,
            AnoLetivoId = dto.AnoLetivoId
        };

        await _turmaRepository.AddAsync(turma);
        await _turmaRepository.SaveChangesAsync();

        return (await GetByIdAsync(turma.Id))!;
    }

    public async Task UpdateAsync(Guid id, UpdateTurmaDto dto)
    {
        var turma = await _turmaRepository.GetByIdAsync(id);
        if (turma == null) return;

        turma.Nome = dto.Nome;
        turma.UpdatedAt = DateTime.UtcNow;

        _turmaRepository.Update(turma);
        await _turmaRepository.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var turma = await _turmaRepository.GetByIdAsync(id);
        if (turma != null)
        {
            _turmaRepository.Remove(turma);
            await _turmaRepository.SaveChangesAsync();
        }
    }
}
