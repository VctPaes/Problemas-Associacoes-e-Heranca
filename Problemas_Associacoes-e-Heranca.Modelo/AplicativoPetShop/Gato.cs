using System;

namespace Problemas_Associacoes_e_Heranca.Modelo.AplicativoPetShop;

public class Gato : Animal
{
    public string Pelagem { get; set; }
    public string Comportamento { get; set; }

    public Gato(string nome, int idade, double peso, Dono dono, string pelagem, string comportamento)
        : base(nome, idade, peso, dono)
    {
        Pelagem = pelagem;
        Comportamento = comportamento;
    }

    public override void ExibirDados()
    {
        Console.WriteLine($"Gato: {Nome}, Pelagem: {Pelagem}, Comportamento: {Comportamento}, Dono: {Dono.Nome}");
    }
}
