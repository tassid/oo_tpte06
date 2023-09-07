public class TipoAtracao
{
    public string Nome { get; set; }
    public int CapacidadeMaxima { get; set; }
}

public class Atracao
{
    public string Nome { get; set; }
    public TipoAtracao Tipo { get; set; }
    public TimeSpan HorarioFuncionamento { get; set; }
}
