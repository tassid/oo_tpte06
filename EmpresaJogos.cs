public class Jogo
{
    public string Nome { get; set; }
    public string Plataforma { get; set; }
    public string Genero { get; set; }
    public List<string> EquipeDesenvolvimento { get; set; }
    public int AnoLancamento { get; set; }
}

public class Empresa
{
    public List<Jogo> Jogos { get; set; }
    public string Nome { get; set; }
    public string Localizacao { get; set; }
    public int AnoFundacao { get; set; }
}
