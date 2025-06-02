using System;

namespace Problemas_Associacoes_e_Heranca.Modelo.ControleVeiculosManutencao;

public class Manutencao
{
    public DateTime DataServico { get; set; }
    public string Descricao { get; set; }
    public string Tipo { get; set; }

    public Manutencao(DateTime dataServico, string descricao, string tipo)
    {
        DataServico = dataServico.Date;
        Descricao = descricao;
        Tipo = tipo;
    }
}
