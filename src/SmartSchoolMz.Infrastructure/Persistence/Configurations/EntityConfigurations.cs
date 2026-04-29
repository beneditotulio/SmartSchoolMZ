using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartSchoolMz.Domain.Entities;

namespace SmartSchoolMz.Infrastructure.Persistence.Configurations;

public class AlunoConfiguration : IEntityTypeConfiguration<Aluno>
{
    public void Configure(EntityTypeBuilder<Aluno> builder)
    {
        builder.HasKey(a => a.Id);
        builder.Property(a => a.NomeCompleto).IsRequired().HasMaxLength(100);
        builder.Property(a => a.NumeroMatricula).IsRequired().HasMaxLength(20);
        builder.HasIndex(a => a.NumeroMatricula).IsUnique();

        builder.HasOne(a => a.Encarregado)
               .WithMany(e => e.Alunos)
               .HasForeignKey(a => a.EncarregadoId)
               .OnDelete(DeleteBehavior.Restrict);
    }
}

public class ProfessorConfiguration : IEntityTypeConfiguration<Professor>
{
    public void Configure(EntityTypeBuilder<Professor> builder)
    {
        builder.HasKey(p => p.Id);
        builder.Property(p => p.NomeCompleto).IsRequired().HasMaxLength(100);
    }
}

public class EncarregadoConfiguration : IEntityTypeConfiguration<Encarregado>
{
    public void Configure(EntityTypeBuilder<Encarregado> builder)
    {
        builder.HasKey(e => e.Id);
        builder.Property(e => e.NomeCompleto).IsRequired().HasMaxLength(100);
    }
}

public class MatriculaConfiguration : IEntityTypeConfiguration<Matricula>
{
    public void Configure(EntityTypeBuilder<Matricula> builder)
    {
        builder.HasKey(m => m.Id);

        builder.HasOne(m => m.Aluno)
               .WithMany(a => a.Matriculas)
               .HasForeignKey(m => m.AlunoId);

        builder.HasOne(m => m.Turma)
               .WithMany(t => t.Matriculas)
               .HasForeignKey(m => m.TurmaId);

        builder.HasOne(m => m.AnoLetivo)
               .WithMany(a => a.Matriculas)
               .HasForeignKey(m => m.AnoLetivoId);
    }
}

public class ProfessorTurmaDisciplinaConfiguration : IEntityTypeConfiguration<ProfessorTurmaDisciplina>
{
    public void Configure(EntityTypeBuilder<ProfessorTurmaDisciplina> builder)
    {
        builder.HasKey(ptd => ptd.Id);

        builder.HasOne(ptd => ptd.Professor)
               .WithMany(p => p.ProfessorTurmaDisciplinas)
               .HasForeignKey(ptd => ptd.ProfessorId);

        builder.HasOne(ptd => ptd.Turma)
               .WithMany(t => t.ProfessorTurmaDisciplinas)
               .HasForeignKey(ptd => ptd.TurmaId);

        builder.HasOne(ptd => ptd.Disciplina)
               .WithMany(d => d.ProfessorTurmaDisciplinas)
               .HasForeignKey(ptd => ptd.DisciplinaId);
    }
}

public class NotaConfiguration : IEntityTypeConfiguration<Nota>
{
    public void Configure(EntityTypeBuilder<Nota> builder)
    {
        builder.HasKey(n => n.Id);
        builder.Property(n => n.Valor).HasPrecision(5, 2);

        builder.HasOne(n => n.Matricula)
               .WithMany(m => m.Notas)
               .HasForeignKey(n => n.MatriculaId);
    }
}

public class PagamentoConfiguration : IEntityTypeConfiguration<Pagamento>
{
    public void Configure(EntityTypeBuilder<Pagamento> builder)
    {
        builder.HasKey(p => p.Id);
        builder.Property(p => p.ValorEsperado).HasPrecision(18, 2);
        builder.Property(p => p.ValorPago).HasPrecision(18, 2);

        builder.HasOne(p => p.Matricula)
               .WithMany(m => m.Pagamentos)
               .HasForeignKey(p => p.MatriculaId);
    }
}
