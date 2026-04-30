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

public record CreateMatriculaDto(
    Guid AlunoId,
    Guid TurmaId,
    Guid AnoLetivoId
);

public record UpdateMatriculaEstadoDto(
    EstadoMatricula Estado
);
