using System;

namespace Problemas_Associacoes_e_Heranca.Modelo.PlataformaStreaming;

public abstract class Midia
{
    public string Titulo { get; set; }
    public string Genero { get; set; }
    public int Duracao { get; set; }

    protected Midia(string titulo, string genero, int duracao)
    {
        Titulo = titulo;
        Genero = genero;
        Duracao = duracao;
    }

    public abstract void ExibirResumo();
}
