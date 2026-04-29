using SmartSchoolMz.Domain.Common;

namespace SmartSchoolMz.Domain.Entities;

public class AnoLetivo : BaseEntity
{
    public int Ano { get; set; }
    public bool Activo { get; set; }
    public DateTime DataInicio { get; set; }
    public DateTime DataFim { get; set; }

    public ICollection<Turma> Turmas { get; set; } = new List<Turma>();
    public ICollection<Matricula> Matriculas { get; set; } = new List<Matricula>();
}

public class Classe : BaseEntity
{
    public string Nome { get; set; } = string.Empty; // ex: 10ª Classe
    public string Nivel { get; set; } = string.Empty; // Primário/Secundário
    public decimal ValorMensalidade { get; set; }

    public ICollection<Turma> Turmas { get; set; } = new List<Turma>();
    public ICollection<Disciplina> Disciplinas { get; set; } = new List<Disciplina>();
}

public class Turma : BaseEntity
{
    public string Nome { get; set; } = string.Empty; // A, B, C
    public Guid ClasseId { get; set; }
    public Classe Classe { get; set; } = null!;
    public Guid AnoLetivoId { get; set; }
    public AnoLetivo AnoLetivo { get; set; } = null!;

    public ICollection<Matricula> Matriculas { get; set; } = new List<Matricula>();
    public ICollection<ProfessorTurmaDisciplina> ProfessorTurmaDisciplinas { get; set; } = new List<ProfessorTurmaDisciplina>();
}

public class Disciplina : BaseEntity
{
    public string Nome { get; set; } = string.Empty;
    public Guid ClasseId { get; set; }
    public Classe Classe { get; set; } = null!;

    public ICollection<ProfessorTurmaDisciplina> ProfessorTurmaDisciplinas { get; set; } = new List<ProfessorTurmaDisciplina>();
}

// Join entity for Professor -> Turma -> Disciplina assignment
public class ProfessorTurmaDisciplina : BaseEntity
{
    public Guid ProfessorId { get; set; }
    public Professor Professor { get; set; } = null!;
    public Guid TurmaId { get; set; }
    public Turma Turma { get; set; } = null!;
    public Guid DisciplinaId { get; set; }
    public Disciplina Disciplina { get; set; } = null!;
}
