using System;

namespace Problemas_Associacoes_e_Heranca.Modelo.AplicativoControleTreinos;

public class Aluno
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public string ObjetivoFisico { get; set; }
    public string MedidasCorporais { get; set; }

    public List<Treino> Treinos { get; private set; } = new();

    public Aluno(string nome, int idade, string objetivoFisico, string medidasCorporais)
    {
        Nome = nome;
        Idade = idade;
        ObjetivoFisico = objetivoFisico;
        MedidasCorporais = medidasCorporais;
    }

    public void AdicionarTreino(Treino treino)
    {
        Treinos.Add(treino);
    }
}
