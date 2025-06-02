using System;

namespace Problemas_Associacoes_e_Heranca.Modelo.AplicativoPetShop;

public class Passaro : Animal
{
    public string Especie { get; set; }
    public string Envergadura { get; set; }

    public Passaro(string nome, int idade, double peso, Dono dono, string especie, string envergadura)
        : base(nome, idade, peso, dono)
    {
        Especie = especie;
        Envergadura = envergadura;
    }

    public override void ExibirDados()
    {
        Console.WriteLine($"Pássaro: {Nome}, Espécie: {Especie}, Envergadura: {Envergadura}, Dono: {Dono.Nome}");
    }
}
