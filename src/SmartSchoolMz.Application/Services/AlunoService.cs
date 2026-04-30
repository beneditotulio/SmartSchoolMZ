using SmartSchoolMz.Application.DTOs;
using SmartSchoolMz.Application.Interfaces;
using SmartSchoolMz.Domain.Entities;
using SmartSchoolMz.Domain.Interfaces;

namespace SmartSchoolMz.Application.Services;

public class AlunoService : IAlunoService
{
    private readonly IRepository<Aluno> _alunoRepository;

    public AlunoService(IRepository<Aluno> alunoRepository)
    {
        _alunoRepository = alunoRepository;
    }

    public async Task<IEnumerable<AlunoDto>> GetAllAsync()
    {
        var alunos = await _alunoRepository.GetAllAsync();
        return alunos.Select(a => MapToDto(a));
    }

    public async Task<AlunoDto?> GetByIdAsync(Guid id)
    {
        var aluno = await _alunoRepository.GetByIdAsync(id);
        return aluno != null ? MapToDto(aluno) : null;
    }

    public async Task<AlunoDto> CreateAsync(CreateAlunoDto dto)
    {
        var aluno = new Aluno
        {
            NomeCompleto = dto.NomeCompleto,
            DataNascimento = dto.DataNascimento,
            Sexo = dto.Sexo,
            DocumentoIdentificacao = dto.DocumentoIdentificacao,
            NumeroMatricula = dto.NumeroMatricula,
            Morada = dto.Morada,
            Contacto = dto.Contacto,
            Email = dto.Email,
            DataIngresso = dto.DataIngresso
        };

        await _alunoRepository.AddAsync(aluno);
        await _alunoRepository.SaveChangesAsync();

        return MapToDto(aluno);
    }

    public async Task UpdateAsync(Guid id, UpdateAlunoDto dto)
    {
        var aluno = await _alunoRepository.GetByIdAsync(id);
        if (aluno == null) return;

        aluno.NomeCompleto = dto.NomeCompleto;
        aluno.Morada = dto.Morada;
        aluno.Contacto = dto.Contacto;
        aluno.Email = dto.Email;
        aluno.Activo = dto.Activo;
        aluno.UpdatedAt = DateTime.UtcNow;

        _alunoRepository.Update(aluno);
        await _alunoRepository.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var aluno = await _alunoRepository.GetByIdAsync(id);
        if (aluno != null)
        {
            _alunoRepository.Remove(aluno);
            await _alunoRepository.SaveChangesAsync();
        }
    }

    private static AlunoDto MapToDto(Aluno a) => new AlunoDto(
        a.Id,
        a.NomeCompleto,
        a.DataNascimento,
        a.Sexo,
        a.DocumentoIdentificacao,
        a.NumeroMatricula,
        a.Morada,
        a.Contacto,
        a.Email,
        a.DataIngresso,
        a.Activo
    );
}
