using System;

namespace Problemas_Associacoes_e_Heranca.Modelo.EventosCulturais;

public class Participante
{
    public string Nome { get; set; }
    public List<Evento> Eventos { get; private set; } = new();

    public Participante(string nome)
    {
        Nome = nome;
    }
}
