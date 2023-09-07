using System;

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

public class LivroDigital : Livro
{
    public string Formato { get; set; }
    public int TamanhoEmMB { get; set; }

    public LivroDigital(string titulo, Autor autor, string genero, string sinopse, string formato, int tamanhoEmMB)
    {
        Titulo = titulo;
        Autor = autor;
        Genero = genero;
        Sinopse = sinopse;
        Formato = formato;
        TamanhoEmMB = tamanhoEmMB;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Autor autor = new Autor
        {
            Nome = "João da Silva",
            Nacionalidade = "Brasileiro",
            AnoNascimento = 1980
        };

        Livro livro = new Livro
        {
            Titulo = "Meu Livro",
            Autor = autor,
            Genero = "Ficção",
            Sinopse = "Uma sinopse fictícia para o livro."
        };

        LivroDigital livroDigital = new LivroDigital
        (
            "Meu Livro Digital",
            autor,
            "Ficção Digital",
            "Uma sinopse fictícia para o livro digital.",
            "PDF",
            5
        );

        Console.WriteLine("Informações do Livro:");
        Console.WriteLine($"Título: {livro.Titulo}");
        Console.WriteLine($"Autor: {livro.Autor.Nome}");
        Console.WriteLine($"Gênero: {livro.Genero}");
        Console.WriteLine($"Sinopse: {livro.Sinopse}");
        
        Console.WriteLine("\nInformações do Livro Digital:");
        Console.WriteLine($"Título: {livroDigital.Titulo}");
        Console.WriteLine($"Autor: {livroDigital.Autor.Nome}");
        Console.WriteLine($"Gênero: {livroDigital.Genero}");
        Console.WriteLine($"Sinopse: {livroDigital.Sinopse}");
        Console.WriteLine($"Formato: {livroDigital.Formato}");
        Console.WriteLine($"Tamanho em MB: {livroDigital.TamanhoEmMB}MB");
    }
}
