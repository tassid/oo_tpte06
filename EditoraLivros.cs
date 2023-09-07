public class Autor
{
    public string Nome { get; set; }
    public string Nacionalidade { get; set; }
    public int AnoNascimento { get; set; }
}

public class Livro
{
    public string Titulo { get; set; }
    public Autor Autor { get; set; }
    public string Genero { get; set; }
    public string Sinopse { get; set; }
}
