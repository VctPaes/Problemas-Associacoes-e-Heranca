using System;

namespace Problemas_Associacoes_e_Heranca.Modelo.PlataformaCursosOnline;

public class Matricula
{
    public Aluno Aluno { get; set; }
    public Curso Curso { get; set; }
    public DateTime DataInscricao { get; set; }
    public double Progresso { get; set; }

    public Matricula(Aluno aluno, Curso curso)
    {
        Aluno = aluno;
        Curso = curso;
        DataInscricao = DateTime.Now;
        Progresso = 0;
    }
}
