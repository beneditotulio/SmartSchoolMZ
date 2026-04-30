using Microsoft.EntityFrameworkCore;
using SmartSchoolMz.Application.DTOs;
using SmartSchoolMz.Application.Interfaces;
using SmartSchoolMz.Domain.Entities;
using SmartSchoolMz.Domain.Enums;
using SmartSchoolMz.Domain.Interfaces;

namespace SmartSchoolMz.Application.Services;

public class AcademicProcessService : IAcademicProcessService
{
    private readonly IRepository<Nota> _notaRepository;
    private readonly IRepository<Frequencia> _frequenciaRepository;
    private readonly IRepository<Pagamento> _pagamentoRepository;
    private readonly IRepository<Matricula> _matriculaRepository;

    public AcademicProcessService(
        IRepository<Nota> notaRepository,
        IRepository<Frequencia> frequenciaRepository,
        IRepository<Pagamento> pagamentoRepository,
        IRepository<Matricula> matriculaRepository)
    {
        _notaRepository = notaRepository;
        _frequenciaRepository = frequenciaRepository;
        _pagamentoRepository = pagamentoRepository;
        _matriculaRepository = matriculaRepository;
    }

    public async Task LançarNotaAsync(CreateNotaDto dto)
    {
        var nota = new Nota
        {
            MatriculaId = dto.MatriculaId,
            DisciplinaId = dto.DisciplinaId,
            Trimestre = dto.Trimestre,
            Tipo = dto.Tipo,
            Valor = dto.Valor
        };

        await _notaRepository.AddAsync(nota);
        await _notaRepository.SaveChangesAsync();
    }

    public async Task RegistarFrequenciaAsync(CreateFrequenciaDto dto)
    {
        var frequencia = new Frequencia
        {
            MatriculaId = dto.MatriculaId,
            Data = dto.Data,
            Presente = dto.Presente,
            Justificacao = dto.Justificacao,
            Observacao = dto.Observacao
        };

        await _frequenciaRepository.AddAsync(frequencia);
        await _frequenciaRepository.SaveChangesAsync();
    }

    public async Task RegistarPagamentoAsync(CreatePagamentoDto dto)
    {
        // Get Matricula with Classe to find ValorMensalidade
        var matricula = await _matriculaRepository.Query()
            .Include(m => m.Turma)
            .ThenInclude(t => t.Classe)
            .FirstOrDefaultAsync(m => m.Id == dto.MatriculaId);

        if (matricula == null) throw new Exception("Matrícula não encontrada");

        var valorEsperado = matricula.Turma.Classe.ValorMensalidade;

        var pagamento = new Pagamento
        {
            MatriculaId = dto.MatriculaId,
            Mes = dto.Mes,
            Ano = dto.Ano,
            ValorEsperado = valorEsperado,
            ValorPago = dto.ValorPago,
            Metodo = dto.Metodo,
            Referencia = dto.Referencia,
            DataPagamento = DateTime.UtcNow,
            Estado = dto.ValorPago >= valorEsperado ? EstadoPagamento.Pago : EstadoPagamento.Pendente
        };

        await _pagamentoRepository.AddAsync(pagamento);
        await _pagamentoRepository.SaveChangesAsync();
    }
}
