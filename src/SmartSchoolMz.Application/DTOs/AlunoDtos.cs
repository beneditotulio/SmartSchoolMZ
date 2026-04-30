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

public record CreateAlunoDto(
    string NomeCompleto,
    DateTime DataNascimento,
    Sexo Sexo,
    string DocumentoIdentificacao,
    string NumeroMatricula,
    string Morada,
    string Contacto,
    string? Email,
    DateTime DataIngresso
);

public record UpdateAlunoDto(
    string NomeCompleto,
    string Morada,
    string Contacto,
    string? Email,
    bool Activo
);
