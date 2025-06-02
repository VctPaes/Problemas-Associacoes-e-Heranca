using System;
using System.Linq;

namespace Problemas_Associacoes_e_Heranca.Modelo.EventosCulturais;

public abstract class Evento
{
    public string Titulo { get; set; }
    public DateTime Data { get; set; }
    public string Hora { get; set; }
    public string Local { get; set; }
    public int Capacidade { get; set; }
    public List<Participante> Participante { get; } = new List<Participante>();

    protected Evento(string titulo, DateTime data, string hora, string local, int capacidade)
    {
        Titulo = titulo;
        Data = data;
        Hora = hora;
        Local = local;
        Capacidade = capacidade;
    }

    public void InscreverParticipante(Participante participante)
    {
        if (!Participante.Contains(participante) && Participante.Count < Capacidade)
        {
            Participante.Add(participante);
            participante.Eventos.Add(this);
        }
    } 

    public abstract void ExibirInformacoes();
}
