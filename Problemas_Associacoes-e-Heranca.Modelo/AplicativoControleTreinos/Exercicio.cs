using System;

namespace Problemas_Associacoes_e_Heranca.Modelo;

public class Exercicio
{
    public string Nome { get; set; }
    public int Series { get; set; }
    public int Repeticoes { get; set; }
    public double Carga { get; set; }

    public Exercicio(string nome, int series, int repeticoes, double carga)
    {
        Nome = nome;
        Series = series;
        Repeticoes = repeticoes;
        Carga = carga;
    }

    public void Editar(int? series = null, int? repeticoes = null, double? carga = null)
    {
        if (series.HasValue) Series = series.Value;
        if (repeticoes.HasValue) Repeticoes = repeticoes.Value;
        if (carga.HasValue) Carga = carga.Value;
    }
}
