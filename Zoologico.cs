using System;
using System.Collections.Generic;

public class Animal
{
    public string Nome { get; set; }
    public string Especie { get; set; }
    public string Habitat { get; set; }
    public string Dieta { get; set; }
    public int Idade { get; set; }
}

public class Zoologico
{
    public List<Animal> Animais { get; set; }
    public string NomeZoologico { get; set; }
    public string Localizacao { get; set; }
    public int AnoFundacao { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        Animal animal1 = new Animal
        {
            Nome = "Leão",
            Especie = "Panthera leo",
            Habitat = "Savana",
            Dieta = "Carnívoro",
            Idade = 8
        };

        Animal animal2 = new Animal
        {
            Nome = "Girafa",
            Especie = "Giraffa camelopardalis",
            Habitat = "Savana",
            Dieta = "Herbívoro",
            Idade = 12
        };

        Zoologico Zoologico = new Zoologico
        {
            NomeZoologico = "Zoologico da Cidade",
            Localizacao = "Cidade do Zoo",
            AnoFundacao = 1975,
            Animais = new List<Animal> { animal1, animal2 }
        };

        Console.WriteLine("Informações do Zoologico:");
        Console.WriteLine($"Nome do Zoologico: {Zoologico.NomeZoologico}");
        Console.WriteLine($"Localização: {Zoologico.Localizacao}");
        Console.WriteLine($"Ano de Fundação: {Zoologico.AnoFundacao}");

        Console.WriteLine("\nInformações dos Animais do Zoologico:");
        foreach (var animal in Zoologico.Animais)
        {
            Console.WriteLine($"Nome do Animal: {animal.Nome}");
            Console.WriteLine($"Espécie: {animal.Especie}");
            Console.WriteLine($"Habitat: {animal.Habitat}");
            Console.WriteLine($"Dieta: {animal.Dieta}");
            Console.WriteLine($"Idade: {animal.Idade}");
            Console.WriteLine();
        }
    }
}
