using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SmartSchoolMz.Domain.Entities;
using System.Reflection;

namespace SmartSchoolMz.Infrastructure.Persistence;

public class ApplicationDbContext : IdentityDbContext<IdentityUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Aluno> Alunos => Set<Aluno>();
    public DbSet<Professor> Professores => Set<Professor>();
    public DbSet<Encarregado> Encarregados => Set<Encarregado>();
    public DbSet<AnoLetivo> AnosLectivos => Set<AnoLetivo>();
    public DbSet<Classe> Classes => Set<Classe>();
    public DbSet<Turma> Turmas => Set<Turma>();
    public DbSet<Disciplina> Disciplinas => Set<Disciplina>();
    public DbSet<Matricula> Matriculas => Set<Matricula>();
    public DbSet<Nota> Notas => Set<Nota>();
    public DbSet<Frequencia> Frequencias => Set<Frequencia>();
    public DbSet<Pagamento> Pagamentos => Set<Pagamento>();
    public DbSet<ProfessorTurmaDisciplina> ProfessorTurmaDisciplinas => Set<ProfessorTurmaDisciplina>();

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
