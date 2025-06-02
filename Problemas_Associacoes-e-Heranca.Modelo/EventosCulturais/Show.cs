using System;

namespace Problemas_Associacoes_e_Heranca.Modelo.EventosCulturais;

public class Show : Evento
{
    public string Artista { get; set; }
    public string EstiloMusical { get; set; }
    public string ClassificacaoEtaria { get; set; }

    public Show(string titulo, DateTime data, string hora, string local, int capacidade, string artista, string estilo, string classificacao)
        : base(titulo, data, hora, local, capacidade)
    {
        Artista = artista;
        EstiloMusical = estilo;
        ClassificacaoEtaria = classificacao;
    }

    public override void ExibirInformacoes()
    {
        Console.WriteLine($"Show: {Titulo} | Artista: {Artista} | Estilo: {EstiloMusical} | Classificação: {ClassificacaoEtaria} | Data: {Data:d} | Horário: {Hora} | Local: {Local}");
    }
}
