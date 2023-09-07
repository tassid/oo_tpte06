public class Animal
{
    public string Nome { get; set; }
    public string Especie { get; set; }
    public string Habitat { get; set; }
    public string Dieta { get; set; }
    public int Idade { get; set; }
}

public class Zoológico
{
    public List<Animal> Animais { get; set; }
    public string Nome { get; set; }
    public string Localizacao { get; set; }
    public int AnoFundacao { get; set; }
}
