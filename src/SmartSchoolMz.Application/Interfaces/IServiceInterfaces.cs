using SmartSchoolMz.Application.DTOs;

namespace SmartSchoolMz.Application.Interfaces;

public interface ITurmaService
{
    Task<IEnumerable<TurmaDto>> GetAllAsync();
    Task<TurmaDto?> GetByIdAsync(Guid id);
    Task<TurmaDto> CreateAsync(CreateTurmaDto dto);
    Task UpdateAsync(Guid id, UpdateTurmaDto dto);
    Task DeleteAsync(Guid id);
}

public interface IMatriculaService
{
    Task<IEnumerable<MatriculaDto>> GetAllAsync();
    Task<MatriculaDto?> GetByIdAsync(Guid id);
    Task<MatriculaDto> CreateAsync(CreateMatriculaDto dto);
    Task UpdateEstadoAsync(Guid id, UpdateMatriculaEstadoDto dto);
}

public interface IAcademicProcessService
{
    Task LançarNotaAsync(CreateNotaDto dto);
    Task RegistarFrequenciaAsync(CreateFrequenciaDto dto);
    Task RegistarPagamentoAsync(CreatePagamentoDto dto);
}
