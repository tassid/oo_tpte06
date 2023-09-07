using System;

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

class Program
{
    static void Main(string[] args)
    {
        Artista artista = new Artista
        {
            Nome = "Leonardo da Vinci",
            Nacionalidade = "Italiano",
            AnoNascimento = 1452
        };

        ObraDeArte obra = new ObraDeArte
        {
            Titulo = "Mona Lisa",
            Artista = artista,
            Periodo = "Renascimento",
            Estilo = "Retrato",
            AnoCriacao = 1503
        };

        Console.WriteLine("Informações da Obra de Arte:");
        Console.WriteLine($"Título: {obra.Titulo}");
        Console.WriteLine($"Artista: {obra.Artista.Nome}");
        Console.WriteLine($"Nacionalidade do Artista: {obra.Artista.Nacionalidade}");
        Console.WriteLine($"Ano de Nascimento do Artista: {obra.Artista.AnoNascimento}");
        Console.WriteLine($"Período: {obra.Periodo}");
        Console.WriteLine($"Estilo: {obra.Estilo}");
        Console.WriteLine($"Ano de Criação: {obra.AnoCriacao}");
    }
}
