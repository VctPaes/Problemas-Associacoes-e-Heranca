using System;

namespace Problemas_Associacoes_e_Heranca.Modelo.PlataformaStreaming;

public class Episodio
{
    public string Titulo { get; set; }
    public int Duracao { get; set; }
    public int Numero { get; set; }

    public Episodio(string titulo, int duracao, int numero)
    {
        Titulo = titulo;
        Duracao = duracao;
        Numero = numero;
    }
}
