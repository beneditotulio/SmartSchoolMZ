namespace SmartSchoolMz.Domain.Enums;

public enum Sexo
{
    Masculino,
    Feminino
}

public enum EstadoMatricula
{
    Activo,
    Trancado,
    Transferido,
    Concluido,
    Cancelado
}

public enum EstadoPagamento
{
    Pendente,
    Pago,
    Atrasado
}

public enum TipoAvaliacao
{
    Teste,
    Trabalho,
    Exame
}

public enum MetodoPagamento
{
    Numerario,
    Transferencia,
    Mpesa,
    Emola
}
