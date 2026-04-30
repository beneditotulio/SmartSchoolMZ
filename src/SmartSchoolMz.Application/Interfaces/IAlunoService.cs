using SmartSchoolMz.Application.DTOs;

namespace SmartSchoolMz.Application.Interfaces;

public interface IAlunoService
{
    Task<IEnumerable<AlunoDto>> GetAllAsync();
    Task<AlunoDto?> GetByIdAsync(Guid id);
    Task<AlunoDto> CreateAsync(CreateAlunoDto dto);
    Task UpdateAsync(Guid id, UpdateAlunoDto dto);
    Task DeleteAsync(Guid id);
}
