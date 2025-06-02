using System;

namespace Problemas_Associacoes_e_Heranca.Modelo.PlataformaCursosOnline;

public class Curso
{
    public string Nome { get; set; }
    public List<Aula> Aulas { get; private set; } = new();

    public Curso(string nome)
    {
        Nome = nome;
    }

    public void AdicionarAula(Aula aula)
    {
        Aulas.Add(aula);
    }
}
