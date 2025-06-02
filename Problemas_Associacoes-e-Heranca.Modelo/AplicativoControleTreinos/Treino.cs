using System;

namespace Problemas_Associacoes_e_Heranca.Modelo.AplicativoControleTreinos;

public class Treino
{
    public DateTime DataCriacao { get; set; }
    public string Objetivo { get; set; }
    public string Tipo { get; set; } // Ex: "superior", "inferior", etc.

    public List<Exercicio> Exercicios { get; private set; } = new();

    public Treino(DateTime dataCriacao, string objetivo, string tipo)
    {
        DataCriacao = dataCriacao;
        Objetivo = objetivo;
        Tipo = tipo;
    }

    public void AdicionarExercicio(Exercicio exercicio)
    {
        Exercicios.Add(exercicio);
    }

    public double CalcularCargaTotal()
    {
        return Exercicios.Sum(e => e.Series * e.Repeticoes * e.Carga);
    }
}
