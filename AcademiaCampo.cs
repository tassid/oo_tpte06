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
    
    public void IniciarAtividade()
    {

    }

    public void EncerrarAtividade()
    {

    }
}

public class Musculacao : Atividade
{
    public int PesoMaximoLevantado { get; set; }
    public int NumeroSeries { get; set; }


}

public class Yoga : Atividade
{
    public string TipoYoga { get; set; }
    public bool RequerTapete { get; set; }

}
