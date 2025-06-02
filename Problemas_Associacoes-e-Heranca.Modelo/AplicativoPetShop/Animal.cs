using System;

namespace Problemas_Associacoes_e_Heranca.Modelo.AplicativoPetShop;

public abstract class Animal
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public double Peso { get; set; }
    public Dono Dono { get; set; }

    protected Animal(string nome, int idade, double peso, Dono dono)
    {
        Nome = nome;
        Idade = idade;
        Peso = peso;
        Dono = dono;
    }

    public abstract void ExibirDados();
}
