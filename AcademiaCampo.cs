using System;
using System.Collections.Generic;

public class Equipamento
{
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public double Peso { get; set; }
}

public class Atividade
{
    public string Nome { get; set; }
    public List<Equipamento> EquipamentosNecessarios { get; set; }
    public int DuracaoEmMinutos { get; set; }
    public string NivelDificuldade { get; set; }

    public virtual void IniciarAtividade()
    {
        Console.WriteLine($"Iniciando a atividade: {Nome}");
    }

    public virtual void EncerrarAtividade()
    {
        Console.WriteLine($"Encerrando a atividade: {Nome}");
    }
}

public class Musculacao : Atividade
{
    public int PesoMaximoLevantado { get; set; }
    public int NumeroSeries { get; set; }

    public Musculacao(string nome, int duracaoEmMinutos, string nivelDificuldade, int pesoMaximoLevantado, int numeroSeries)
    {
        Nome = nome;
        DuracaoEmMinutos = duracaoEmMinutos;
        NivelDificuldade = nivelDificuldade;
        PesoMaximoLevantado = pesoMaximoLevantado;
        NumeroSeries = numeroSeries;
        EquipamentosNecessarios = new List<Equipamento>();
    }

    public override void IniciarAtividade()
    {
        base.IniciarAtividade();
        Console.WriteLine("Realizando aquecimento.");
    }

    public override void EncerrarAtividade()
    {
        base.EncerrarAtividade();
        Console.WriteLine("Realizando alongamento.");
    }
}

public class Yoga : Atividade
{
    public string TipoYoga { get; set; }
    public bool RequerTapete { get; set; }

    public Yoga(string nome, int duracaoEmMinutos, string nivelDificuldade, string tipoYoga, bool requerTapete)
    {
        Nome = nome;
        DuracaoEmMinutos = duracaoEmMinutos;
        NivelDificuldade = nivelDificuldade;
        TipoYoga = tipoYoga;
        RequerTapete = requerTapete;
        EquipamentosNecessarios = new List<Equipamento>();
    }

    public override void IniciarAtividade()
    {
        base.IniciarAtividade();
        Console.WriteLine("Realizando meditação.");
    }

    public override void EncerrarAtividade()
    {
        base.EncerrarAtividade();
        Console.WriteLine("Finalizando a prática de yoga.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Musculacao musculacao = new Musculacao("Levantamento de Peso", 60, "Avançado", 100, 3);
        musculacao.EquipamentosNecessarios.Add(new Equipamento { Nome = "Haltere", Peso = 10 });

        Yoga yoga = new Yoga("Yoga Matinal", 45, "Iniciante", "Hatha Yoga", true);
        yoga.EquipamentosNecessarios.Add(new Equipamento { Nome = "Tapete de Yoga" });

        musculacao.IniciarAtividade();
        musculacao.EncerrarAtividade();

        yoga.IniciarAtividade();
        yoga.EncerrarAtividade();
    }
}
