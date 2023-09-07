using System;
using System.Collections.Generic;

public class Musico
{
    public string Nome { get; set; }
    public string Instrumento { get; set; }
    public int Idade { get; set; }
}

public class OrquestraSinfonica
{
    public List<Musico> Musicos { get; set; }
    public string NomeOrquestra { get; set; }
    public string Localizacao { get; set; }
    public int AnoFundacao { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        Musico musico1 = new Musico
        {
            Nome = "Alice",
            Instrumento = "Violino",
            Idade = 30
        };

        Musico musico2 = new Musico
        {
            Nome = "Bob",
            Instrumento = "Flauta",
            Idade = 28
        };

        OrquestraSinfonica orquestra = new OrquestraSinfonica
        {
            NomeOrquestra = "Orquestra Filarmônica",
            Localizacao = "Nova York",
            AnoFundacao = 1900,
            Musicos = new List<Musico> { musico1, musico2 }
        };

        Console.WriteLine("Informações da Orquestra Sinfônica:");
        Console.WriteLine($"Nome da Orquestra: {orquestra.NomeOrquestra}");
        Console.WriteLine($"Localização: {orquestra.Localizacao}");
        Console.WriteLine($"Ano de Fundação: {orquestra.AnoFundacao}");

        Console.WriteLine("\nInformações dos Músicos da Orquestra:");
        foreach (var musico in orquestra.Musicos)
        {
            Console.WriteLine($"Nome do Músico: {musico.Nome}");
            Console.WriteLine($"Instrumento: {musico.Instrumento}");
            Console.WriteLine($"Idade: {musico.Idade}");
            Console.WriteLine();
        }
    }
}
