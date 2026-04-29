using SmartSchoolMz.Domain.Common;
using SmartSchoolMz.Domain.Enums;

namespace SmartSchoolMz.Domain.Entities;

public class Matricula : BaseEntity
{
    public Guid AlunoId { get; set; }
    public Aluno Aluno { get; set; } = null!;
    public Guid TurmaId { get; set; }
    public Turma Turma { get; set; } = null!;
    public Guid AnoLetivoId { get; set; }
    public AnoLetivo AnoLetivo { get; set; } = null!;
    public DateTime DataMatricula { get; set; } = DateTime.UtcNow;
    public EstadoMatricula Estado { get; set; } = EstadoMatricula.Activo;

    public ICollection<Nota> Notas { get; set; } = new List<Nota>();
    public ICollection<Frequencia> Frequencias { get; set; } = new List<Frequencia>();
    public ICollection<Pagamento> Pagamentos { get; set; } = new List<Pagamento>();
}

public class Nota : BaseEntity
{
    public Guid MatriculaId { get; set; }
    public Matricula Matricula { get; set; } = null!;
    public Guid DisciplinaId { get; set; }
    public Disciplina Disciplina { get; set; } = null!;
    public int Trimestre { get; set; } // 1, 2, 3
    public TipoAvaliacao Tipo { get; set; }
    public decimal Valor { get; set; }
}

public class Frequencia : BaseEntity
{
    public Guid MatriculaId { get; set; }
    public Matricula Matricula { get; set; } = null!;
    public DateTime Data { get; set; }
    public bool Presente { get; set; }
    public string? Justificacao { get; set; }
    public string? Observacao { get; set; }
}

public class Pagamento : BaseEntity
{
    public Guid MatriculaId { get; set; }
    public Matricula Matricula { get; set; } = null!;
    public string Mes { get; set; } = string.Empty;
    public int Ano { get; set; }
    public decimal ValorEsperado { get; set; }
    public decimal ValorPago { get; set; }
    public EstadoPagamento Estado { get; set; } = EstadoPagamento.Pendente;
    public MetodoPagamento? Metodo { get; set; }
    public DateTime? DataPagamento { get; set; }
    public string? Referencia { get; set; }
}
