using SmartSchoolMz.Domain.Enums;

namespace SmartSchoolMz.Application.DTOs;

public record MatriculaDto(
    Guid Id,
    Guid AlunoId,
    string AlunoNome,
    Guid TurmaId,
    string TurmaNome,
    Guid AnoLetivoId,
    int Ano,
    DateTime DataMatricula,
    EstadoMatricula Estado
);

public class CreateMatriculaDto
{
    public Guid AlunoId { get; set; }
    public Guid TurmaId { get; set; }
    public Guid AnoLetivoId { get; set; }
}

public record UpdateMatriculaEstadoDto(
    EstadoMatricula Estado
);
