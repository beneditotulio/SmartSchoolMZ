using SmartSchoolMz.Domain.Enums;

namespace SmartSchoolMz.Application.DTOs;

public record CreateNotaDto(
    Guid MatriculaId,
    Guid DisciplinaId,
    int Trimestre,
    TipoAvaliacao Tipo,
    decimal Valor
);

public record CreateFrequenciaDto(
    Guid MatriculaId,
    DateTime Data,
    bool Presente,
    string? Justificacao,
    string? Observacao
);

public record CreatePagamentoDto(
    Guid MatriculaId,
    string Mes,
    int Ano,
    decimal ValorPago,
    MetodoPagamento Metodo,
    string? Referencia
);
