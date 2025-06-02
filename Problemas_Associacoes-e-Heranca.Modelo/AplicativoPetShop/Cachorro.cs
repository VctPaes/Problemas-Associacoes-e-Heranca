using System;

namespace Problemas_Associacoes_e_Heranca.Modelo.AplicativoPetShop;

public class Cachorro : Animal
{
    public string Raca { get; set; }
    public string Porte { get; set; }
    public string Temperamento { get; set; }

    public Cachorro(string nome, int idade, double peso, Dono dono, string raca, string porte, string temperamento)
        : base(nome, idade, peso, dono)
    {
        Raca = raca;
        Porte = porte;
        Temperamento = temperamento;
    }

    public override void ExibirDados()
    {
        Console.WriteLine($"Cachorro: {Nome}, Raça: {Raca}, Porte: {Porte}, Temperamento: {Temperamento}, Dono: {Dono.Nome}");
    }
}
