using SmartSchoolMz.Domain.Enums;

namespace SmartSchoolMz.Application.DTOs;

public record AlunoDto(
    Guid Id,
    string NomeCompleto,
    DateTime DataNascimento,
    Sexo Sexo,
    string DocumentoIdentificacao,
    string NumeroMatricula,
    string Morada,
    string Contacto,
    string? Email,
    DateTime DataIngresso,
    bool Activo
);

public class CreateAlunoDto
{
    public string NomeCompleto { get; set; } = string.Empty;
    public DateTime DataNascimento { get; set; }
    public Sexo Sexo { get; set; }
    public string DocumentoIdentificacao { get; set; } = string.Empty;
    public string NumeroMatricula { get; set; } = string.Empty;
    public string Morada { get; set; } = string.Empty;
    public string Contacto { get; set; } = string.Empty;
    public string? Email { get; set; }
    public DateTime DataIngresso { get; set; }
}

public record UpdateAlunoDto(
    string NomeCompleto,
    string Morada,
    string Contacto,
    string? Email,
    bool Activo
);
