using System;

namespace Problemas_Associacoes_e_Heranca.Modelo.PlataformaStreaming;

public class Documentario : Midia
{
    public string Tema { get; set; }
    public string Narrador { get; set; }

    public Documentario(string titulo, string genero, int duracao, string tema, string narrador)
        : base(titulo, genero, duracao)
    {
        Tema = tema;
        Narrador = narrador;
    }

    public override void ExibirResumo()
    {
        Console.WriteLine($"Documentário: {Titulo} Tema: {Tema} Narrador: {Narrador} Gênero: {Genero} Duração: {Duracao} min");
    }
}
