using System;

namespace Problemas_Associacoes_e_Heranca.Modelo.SistemaRecrutamento;

public class Vaga
{
    public string Titulo { get; set; }
    public string Empresa { get; set; }
    public string Descricao { get; set; }

    public List<Candidatura> Candidaturas { get; set; } = new();

    public Vaga(string titulo, string empresa, string descricao)
    {
        Titulo = titulo;
        Empresa = empresa;
        Descricao = descricao;
    }
}
