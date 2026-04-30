namespace SmartSchoolMz.Application.DTOs;

public record TurmaDto(
    Guid Id,
    string Nome,
    Guid ClasseId,
    string ClasseNome,
    Guid AnoLetivoId,
    int Ano
);

public record CreateTurmaDto(
    string Nome,
    Guid ClasseId,
    Guid AnoLetivoId
);

public record UpdateTurmaDto(
    string Nome
);
