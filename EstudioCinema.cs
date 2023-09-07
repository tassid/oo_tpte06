using System;

public class MembroEquipe
{
    public string Nome { get; set; }
    public string Funcao { get; set; }
    public int AnoNascimento { get; set; }
}

public class Diretor : MembroEquipe
{
    public int NumeroFilmesDirigidos { get; set; }
}

public class Ator : MembroEquipe
{
    public string GeneroAtuacao { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        Diretor diretor = new Diretor
        {
            Nome = "Steven Spielberg",
            Funcao = "Diretor",
            AnoNascimento = 1946,
            NumeroFilmesDirigidos = 30
        };

        Ator ator = new Ator
        {
            Nome = "Tom Hanks",
            Funcao = "Ator",
            AnoNascimento = 1956,
            GeneroAtuacao = "Drama"
        };

        Console.WriteLine("Informações do Diretor:");
        Console.WriteLine($"Nome: {diretor.Nome}");
        Console.WriteLine($"Função: {diretor.Funcao}");
        Console.WriteLine($"Ano de Nascimento: {diretor.AnoNascimento}");
        Console.WriteLine($"Número de Filmes Dirigidos: {diretor.NumeroFilmesDirigidos}");

        Console.WriteLine("\nInformações do Ator:");
        Console.WriteLine($"Nome: {ator.Nome}");
        Console.WriteLine($"Função: {ator.Funcao}");
        Console.WriteLine($"Ano de Nascimento: {ator.AnoNascimento}");
        Console.WriteLine($"Gênero de Atuação: {ator.GeneroAtuacao}");
    }
}
