using System;

namespace Problemas_Associacoes_e_Heranca.Modelo.AplicativoPetShop;

public class Dono
{
    public string Nome { get; set; }
    public List<Animal> Animais { get; set; } = new();

    public Dono(string nome)
    {
        Nome = nome;
    }
}
