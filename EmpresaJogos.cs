using System;
using System.Collections.Generic;

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

public class Estudio : Empresa
{
    public string Especializacao { get; set; }
    public string CEO { get; set; }

    public Estudio(string nome, string localizacao, int anoFundacao, string especializacao, string ceo)
    {
        Nome = nome;
        Localizacao = localizacao;
        AnoFundacao = anoFundacao;
        Especializacao = especializacao;
        CEO = ceo;
        Jogos = new List<Jogo>();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Jogo jogo1 = new Jogo
        {
            Nome = "Super Jogo",
            Plataforma = "PlayStation",
            Genero = "Ação",
            EquipeDesenvolvimento = new List<string> { "Programador A", "Artista B" },
            AnoLancamento = 2022
        };

        Jogo jogo2 = new Jogo
        {
            Nome = "Outro Jogo",
            Plataforma = "Xbox",
            Genero = "Aventura",
            EquipeDesenvolvimento = new List<string> { "Programador C", "Artista D" },
            AnoLancamento = 2023
        };

        Estudio estudio = new Estudio
        (
            "Estúdio X",
            "Los Angeles",
            1990,
            "Jogos de Ação",
            "CEO Z"
        );

        estudio.Jogos.Add(jogo1);
        estudio.Jogos.Add(jogo2);

        Console.WriteLine("Informações do Estúdio:");
        Console.WriteLine($"Nome: {estudio.Nome}");
        Console.WriteLine($"Localização: {estudio.Localizacao}");
        Console.WriteLine($"Ano de Fundação: {estudio.AnoFundacao}");
        Console.WriteLine($"Especialização: {estudio.Especializacao}");
        Console.WriteLine($"CEO: {estudio.CEO}");
        Console.WriteLine("\nJogos Desenvolvidos pelo Estúdio:");
        foreach (var jogo in estudio.Jogos)
        {
            Console.WriteLine($"Nome do Jogo: {jogo.Nome}");
            Console.WriteLine($"Plataforma: {jogo.Plataforma}");
            Console.WriteLine($"Gênero: {jogo.Genero}");
            Console.WriteLine($"Ano de Lançamento: {jogo.AnoLancamento}");
            Console.WriteLine($"Equipe de Desenvolvimento: {string.Join(", ", jogo.EquipeDesenvolvimento)}");
            Console.WriteLine();
        }
    }
}
