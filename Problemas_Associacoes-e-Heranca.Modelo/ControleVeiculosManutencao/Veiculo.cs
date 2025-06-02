using System;


namespace Problemas_Associacoes_e_Heranca.Modelo.ControleVeiculosManutencao;

public class Veiculo
{
    public string Modelo { get; set; }
    public string Placa { get; set; }
    public string Tipo { get; set; }

    private List<Manutencao> manutencoes = new();
    public IReadOnlyList<Manutencao> Manutencoes => manutencoes.AsReadOnly();

    public void AdicionarManutencao(Manutencao manutencao)
    {
        if (manutencoes.Any(m => m.DataServico.Date == manutencao.DataServico.Date))
            throw new InvalidOperationException("Já existe uma manutenção registrada para este veículo nesta data.");

        manutencoes.Add(manutencao);
    }
}
