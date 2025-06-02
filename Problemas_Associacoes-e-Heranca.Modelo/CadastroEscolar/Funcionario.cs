using System;

namespace Problemas_Associacoes_e_Heranca.Modelo.CadastroEscolar;

public class Funcionario : Pessoa
{
    public string Setor { get; set; }

    public Funcionario(string nome, string cpf, DateTime dataNascimento, string setor)
        : base(nome, cpf, dataNascimento)
    {
        Setor = setor;
    }

    public override void ExibirDados()
    {
        Console.WriteLine($"Funcionário: {Nome}, Setor: {Setor}");
    }
}