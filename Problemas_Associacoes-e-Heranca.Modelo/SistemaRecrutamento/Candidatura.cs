using System;

namespace Problemas_Associacoes_e_Heranca.Modelo.SistemaRecrutamento;

public class Candidatura
{
    public Candidato Candidato { get; set; }
    public Vaga Vaga { get; set; }
    public DateTime DataEnvio { get; set; }
    public string Status { get; set; } 

    public Candidatura(Candidato candidato, Vaga vaga)
    {
        Candidato = candidato;
        Vaga = vaga;
        DataEnvio = DateTime.Now;
        Status = "enviada";

        candidato.Candidaturas.Add(this);
        vaga.Candidaturas.Add(this);
    }
}
