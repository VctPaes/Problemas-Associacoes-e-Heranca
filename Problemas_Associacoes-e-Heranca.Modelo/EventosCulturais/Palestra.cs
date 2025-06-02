using System;

namespace Problemas_Associacoes_e_Heranca.Modelo.EventosCulturais;

public class Palestra : Evento
{
    public string Palestrante { get; set; }
    public string Topico { get; set; }
    public int DuracaoPrevista { get; set; }

    public Palestra(string titulo, DateTime data, string horario, string local, int capacidade, string palestrante, string topico, int duracao)
        : base(titulo, data, horario, local, capacidade)
    {
        Palestrante = palestrante;
        Topico = topico;
        DuracaoPrevista = duracao;
    }

    public override void ExibirInformacoes()
    {
        Console.WriteLine($"Palestra: {Titulo} | Palestrante: {Palestrante} | Tópico: {Topico} | Duração: {DuracaoPrevista} min | Data: {Data:d} | Horário: {Hora} | Local: {Local}");
    }
}
