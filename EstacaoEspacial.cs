public class TipoModulo
{
    public string Nome { get; set; }
    public string Funcao { get; set; }
}

public class Modulo
{
    public string Nome { get; set; }
    public TipoModulo Tipo { get; set; }
    public string Status { get; set; }
}
