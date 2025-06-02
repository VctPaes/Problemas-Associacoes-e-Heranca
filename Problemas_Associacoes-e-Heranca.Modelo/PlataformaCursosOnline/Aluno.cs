using System;

namespace Problemas_Associacoes_e_Heranca.Modelo.PlataformaCursosOnline;

public class Aluno
{
    public string Nome { get; set; }
    public List<Matricula> Matriculas { get; set; } = new();

    public Aluno(string nome)
    {
        Nome = nome;
    }
}
