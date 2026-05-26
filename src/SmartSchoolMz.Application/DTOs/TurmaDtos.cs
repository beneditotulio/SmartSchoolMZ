namespace SmartSchoolMz.Application.DTOs;

public record TurmaDto(
    Guid Id,
    string Nome,
    Guid ClasseId,
    string ClasseNome,
    Guid AnoLetivoId,
    int Ano
);

public class CreateTurmaDto
{
    public string Nome { get; set; } = string.Empty;
    public Guid ClasseId { get; set; }
    public Guid AnoLetivoId { get; set; }
}

public record UpdateTurmaDto(
    string Nome
);
