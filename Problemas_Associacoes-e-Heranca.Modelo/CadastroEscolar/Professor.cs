using System;

namespace Problemas_Associacoes_e_Heranca.Modelo.CadastroEscolar;

public class Professor : Pessoa
{
    public List<string> Disciplinas { get; set; } = new();

    public Professor(string nome, string cpf, DateTime dataNascimento, List<string> disciplinas)
        : base(nome, cpf, dataNascimento)
    {
        Disciplinas = disciplinas;
    }

    public override void ExibirDados()
    {
        Console.WriteLine($"Professor: {Nome}, Disciplinas: {string.Join(", ", Disciplinas)}");
    }
}