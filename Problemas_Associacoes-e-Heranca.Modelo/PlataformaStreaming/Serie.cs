using System;

namespace Problemas_Associacoes_e_Heranca.Modelo.PlataformaStreaming;

public class Serie : Midia
{
    public int Temporadas { get; set; }
    public List<Episodio> Episodios { get; private set; } = new();

    public Serie(string titulo, string genero, int duracao, int temporadas)
        : base(titulo, genero, duracao)
    {
        Temporadas = temporadas;
    }

    public void AdicionarEpisodio(Episodio episodio)
    {
        Episodios.Add(episodio);
    }

    public override void ExibirResumo()
    {
        Console.WriteLine($"Série: {Titulo} Gênero: {Genero} Temporadas: {Temporadas} Episódios: {Episodios.Count}");
    }
}
