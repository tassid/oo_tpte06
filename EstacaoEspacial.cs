using System;

public class TipoModulo
{
    public string Nome { get; set; }
    public string Funcao { get; set; }
}

public class TipoModuloEspecializado : TipoModulo
{
    public string Caracteristica { get; set; }

    public TipoModuloEspecializado(string nome, string funcao, string caracteristica)
    {
        Nome = nome;
        Funcao = funcao;
        Caracteristica = caracteristica;
    }
}

public class Modulo
{
    public string Nome { get; set; }
    public TipoModulo Tipo { get; set; }
    public string Status { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        TipoModulo tipoPadrao = new TipoModulo
        {
            Nome = "Padrão",
            Funcao = "Função Padrão"
        };

        TipoModuloEspecializado tipoEspecializado = new TipoModuloEspecializado
        (
            "Especializado",
            "Função Especializada",
            "Característica Especial"
        );

        Modulo modulo1 = new Modulo
        {
            Nome = "Módulo 1",
            Tipo = tipoPadrao,
            Status = "Ativo"
        };

        Modulo modulo2 = new Modulo
        {
            Nome = "Módulo 2",
            Tipo = tipoEspecializado,
            Status = "Inativo"
        };

        Console.WriteLine("Informações do Módulo 1:");
        Console.WriteLine($"Nome: {modulo1.Nome}");
        Console.WriteLine($"Tipo: {modulo1.Tipo.Nome}");
        Console.WriteLine($"Função: {modulo1.Tipo.Funcao}");
        Console.WriteLine($"Status: {modulo1.Status}");

        Console.WriteLine("\nInformações do Módulo 2:");
        Console.WriteLine($"Nome: {modulo2.Nome}");
        Console.WriteLine($"Tipo: {modulo2.Tipo.Nome}");
        Console.WriteLine($"Função: {modulo2.Tipo.Funcao}");
        Console.WriteLine($"Característica: {(modulo2.Tipo as TipoModuloEspecializado)?.Caracteristica}");
        Console.WriteLine($"Status: {modulo2.Status}");
    }
}
