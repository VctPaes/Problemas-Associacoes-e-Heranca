using System;

namespace Problemas_Associacoes_e_Heranca.Modelo.PlataformaStreaming;

public class Filme : Midia
{
    public string Diretor { get; set; }
    public int Ano { get; set; }
    public string Elenco { get; set; }

    public Filme(string titulo, string genero, int duracao, string diretor, int ano, string elenco)
        : base(titulo, genero, duracao)
    {
        Diretor = diretor;
        Ano = ano;
        Elenco = elenco;
    }

    public override void ExibirResumo()
    {
        Console.WriteLine($"Filme: {Titulo} Gênero: {Genero} Duração: {Duracao} min Diretor: {Diretor} Ano: {Ano}");
    }
}
