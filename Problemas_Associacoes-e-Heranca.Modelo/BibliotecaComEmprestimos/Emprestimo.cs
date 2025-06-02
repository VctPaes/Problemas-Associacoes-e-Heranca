using System;

namespace Problemas_Associacoes_e_Heranca.Modelo;

public class Emprestimo
{
    public Livro Livro { get; private set; }
    public Leitor Leitor { get; private set; }
    public DateTime DataEmprestimo { get; private set; }
    public DateTime? DataDevolucao { get; private set; }

    public Emprestimo(Livro livro, Leitor leitor)
    {
        if (!livro.Disponivel)
            throw new InvalidOperationException("Livro já está emprestado.");

        Livro = livro;
        Leitor = leitor;
        DataEmprestimo = DateTime.Now;
        DataDevolucao = null;

        livro.Disponivel = false;
        leitor.Emprestimos.Add(this);
    }

    public void Devolver()
    {
        if (DataDevolucao != null)
            throw new InvalidOperationException("Livro já foi devolvido.");

        DataDevolucao = DateTime.Now;
        Livro.Disponivel = true;
    }
}
