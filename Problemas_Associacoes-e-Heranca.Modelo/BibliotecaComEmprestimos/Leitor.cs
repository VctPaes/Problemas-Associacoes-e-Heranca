using System;

namespace Problemas_Associacoes_e_Heranca.Modelo;

public class Leitor
{
    public string Nome { get; set; }
    public List<Emprestimo> Emprestimos { get; set; } = new();

    public Leitor(string nome)
    {
        Nome = nome;
    }
}
