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
