using System;

namespace Problemas_Associacoes_e_Heranca.Modelo.SistemaRecrutamento;

public class Candidato
{
    public string NomeCompleto { get; set; }
    public string Email { get; set; }
    public string Curriculo { get; set; }

    public List<Candidatura> Candidaturas { get; set; } = new();

    public Candidato(string nomeCompleto, string email, string curriculo)
    {
        NomeCompleto = nomeCompleto;
        Email = email;
        Curriculo = curriculo;
    }
}
