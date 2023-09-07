public class Artista
{
    public string Nome { get; set; }
    public string Nacionalidade { get; set; }
    public int AnoNascimento { get; set; }
}

public class ObraDeArte
{
    public string Titulo { get; set; }
    public Artista Artista { get; set; }
    public string Periodo { get; set; }
    public string Estilo { get; set; }
    public int AnoCriacao { get; set; }
}
