using SmartSchoolMz.Domain.Enums;

namespace SmartSchoolMz.Application.DTOs;

public class CreateNotaDto
{
    public Guid MatriculaId { get; set; }
    public Guid DisciplinaId { get; set; }
    public int Trimestre { get; set; }
    public TipoAvaliacao Tipo { get; set; }
    public decimal Valor { get; set; }
}

public class CreateFrequenciaDto
{
    public Guid MatriculaId { get; set; }
    public DateTime Data { get; set; }
    public bool Presente { get; set; }
    public string? Justificacao { get; set; }
    public string? Observacao { get; set; }
}

public class CreatePagamentoDto
{
    public Guid MatriculaId { get; set; }
    public string Mes { get; set; } = string.Empty;
    public int Ano { get; set; }
    public decimal ValorPago { get; set; }
    public MetodoPagamento Metodo { get; set; }
    public string? Referencia { get; set; }
}
