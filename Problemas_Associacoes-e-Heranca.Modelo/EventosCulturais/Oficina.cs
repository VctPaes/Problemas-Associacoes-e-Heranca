using System;

namespace Problemas_Associacoes_e_Heranca.Modelo.EventosCulturais;

public class Oficina : Evento
{
    public string MaterialNecessario { get; set; }
    public int NumeroMaximoParticipantes { get; set; }

    public Oficina(string titulo, DateTime data, string horario, string local, int capacidade, string materialNecessario, int numeroMaximo)
        : base(titulo, data, horario, local, capacidade)
    {
        MaterialNecessario = materialNecessario;
        NumeroMaximoParticipantes = numeroMaximo;
    }

    public override void ExibirInformacoes()
    {
        Console.WriteLine($"Oficina: {Titulo} | Data: {Data:d} | Horário: {Hora} | Local: {Local} | Material: {MaterialNecessario} | Vagas: {NumeroMaximoParticipantes}");
    }
}
