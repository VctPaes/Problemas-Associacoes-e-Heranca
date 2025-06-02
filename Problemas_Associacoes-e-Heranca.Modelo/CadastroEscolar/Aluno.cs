using System;

namespace Problemas_Associacoes_e_Heranca.Modelo.CadastroEscolar;

public class Aluno : Pessoa
{
    public string Matricula { get; set; }
    public string Turma { get; set; }

    public Aluno(string nome, string cpf, DateTime dataNascimento, string matricula, string turma)
        : base(nome, cpf, dataNascimento)
    {
        Matricula = matricula;
        Turma = turma;
    }

    public override void ExibirDados()
    {
        Console.WriteLine($"Aluno: {Nome}, Matrícula: {Matricula}, Turma: {Turma}");
    }
}