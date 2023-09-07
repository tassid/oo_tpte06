using System;
using System.Collections.Generic;

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

public class ParqueDiversoes
{
    public List<Atracao> Atracoes { get; set; }
    public string NomeParque { get; set; }
    public string Localizacao { get; set; }
    public int AnoFundacao { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        TipoAtracao tipo1 = new TipoAtracao
        {
            Nome = "Montanha-Russa",
            CapacidadeMaxima = 50
        };

        TipoAtracao tipo2 = new TipoAtracao
        {
            Nome = "Carrossel",
            CapacidadeMaxima = 30
        };

        Atracao atracao1 = new Atracao
        {
            Nome = "Montanha-Russa Radical",
            Tipo = tipo1,
            HorarioFuncionamento = TimeSpan.FromHours(10) // Abre às 10:00
        };

        Atracao atracao2 = new Atracao
        {
            Nome = "Carrossel Encantado",
            Tipo = tipo2,
            HorarioFuncionamento = TimeSpan.FromHours(11) // Abre às 11:00
        };

        ParqueDiversoes parque = new ParqueDiversoes
        {
            NomeParque = "Parque da Aventura",
            Localizacao = "Cidade do Divertimento",
            AnoFundacao = 1990,
            Atracoes = new List<Atracao> { atracao1, atracao2 }
        };

        Console.WriteLine("Informações do Parque de Diversões:");
        Console.WriteLine($"Nome do Parque: {parque.NomeParque}");
        Console.WriteLine($"Localização: {parque.Localizacao}");
        Console.WriteLine($"Ano de Fundação: {parque.AnoFundacao}");

        Console.WriteLine("\nInformações das Atrações do Parque:");
        foreach (var atracao in parque.Atracoes)
        {
            Console.WriteLine($"Nome da Atração: {atracao.Nome}");
            Console.WriteLine($"Tipo de Atração: {atracao.Tipo.Nome}");
            Console.WriteLine($"Capacidade Máxima: {atracao.Tipo.CapacidadeMaxima}");
            Console.WriteLine($"Horário de Funcionamento: {atracao.HorarioFuncionamento}");
            Console.WriteLine();
        }
    }
}
