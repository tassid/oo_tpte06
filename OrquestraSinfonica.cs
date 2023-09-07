public class Modelo
{
    public string Nome { get; set; }
    public List<string> Especialidades { get; set; }
    public string Portfolio { get; set; }
    public int Idade { get; set; }
}
public class Agencia
{
    public List<Modelo> Modelos { get; set; }
    public string NomeAgencia { get; set; }
    public string Localizacao { get; set; }
    public int AnoFundacao { get; set; }
}
