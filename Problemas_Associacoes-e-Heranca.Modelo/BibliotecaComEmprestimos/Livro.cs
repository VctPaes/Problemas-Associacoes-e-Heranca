using System;

namespace Problemas_Associacoes_e_Heranca.Modelo;

public class Livro
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public bool Disponivel { get; set; } = true;

    public Livro(string titulo, string autor)
    {
        Titulo = titulo;
        Autor = autor;
    }
}
