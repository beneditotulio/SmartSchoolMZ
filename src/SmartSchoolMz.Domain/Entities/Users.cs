using SmartSchoolMz.Domain.Common;
using SmartSchoolMz.Domain.Enums;

namespace SmartSchoolMz.Domain.Entities;

public class Aluno : BaseEntity
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
    public bool Activo { get; set; } = true;

    public string? UserId { get; set; } // Identity link

    public Guid? EncarregadoId { get; set; }
    public Encarregado? Encarregado { get; set; }

    public ICollection<Matricula> Matriculas { get; set; } = new List<Matricula>();
}

public class Professor : BaseEntity
{
    public string NomeCompleto { get; set; } = string.Empty;
    public string Especialidade { get; set; } = string.Empty;
    public string DocumentoIdentificacao { get; set; } = string.Empty;
    public string Contacto { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;

    public string? UserId { get; set; } // Identity link

    public ICollection<ProfessorTurmaDisciplina> ProfessorTurmaDisciplinas { get; set; } = new List<ProfessorTurmaDisciplina>();
}

public class Encarregado : BaseEntity
{
    public string NomeCompleto { get; set; } = string.Empty;
    public string GrauParentesco { get; set; } = string.Empty;
    public string DocumentoIdentificacao { get; set; } = string.Empty;
    public string Contacto { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Morada { get; set; } = string.Empty;
    public bool ResponsavelFinanceiro { get; set; }

    public string? UserId { get; set; } // Identity link

    public ICollection<Aluno> Alunos { get; set; } = new List<Aluno>();
}
