using System.Linq;
using ScreenSoundAPI.Modelos;

namespace ScreenSoundAPI.Filtros;

internal class LinqFiltro
{
    public static void FiltrarGeneros(List<Musica> musicas)
    {
        var generos = musicas.Select(generos => generos.Genero).Distinct().ToList();
        foreach (var genero in generos)
        {
            Console.WriteLine($"- {genero}");
        }
    }

    public static void FiltrarArtistasPorGenero(List<Musica> musicas, string genero)
    {
        var artistasPorGenero = musicas.Where(musica => musica.Genero.Contains(genero)).OrderBy(musica => musica.Artista)
            .Select(musica => musica.Artista).Distinct().ToList();
        Console.WriteLine($"Exibindo artistas por genero musical >>> {genero}");

        foreach(var artista in artistasPorGenero)
        {
            Console.WriteLine($"- {artista}");
        }
    }

    public static void FiltrarMusicasDeUmArtista(List<Musica> musicas, string nomeDoArtista)
    {
        var musicasDoArtista = musicas.Where(musica => musica.Artista!
        .Equals(nomeDoArtista)).ToList();
        Console.WriteLine(nomeDoArtista);
        foreach (var musica in musicasDoArtista)
        {
            Console.WriteLine($"- {musica.Nome}");
        }

    }

    public static void FiltrarMusicaPorAno (List<Musica> musicas, int ano)
    { var musicasPorAno = musicas.Where(musica => musica.Ano == ano).OrderBy(musicas => musicas.Nome)
            .Select(musicas => musicas.Nome).Distinct().ToList();

        Console.WriteLine($"Exibindo musicas do ano de {ano}");
        foreach (var musica in musicasPorAno)
        {
            Console.WriteLine($"- {musica}");
        }
    }

    public static void FiltrarMusicaPorTonalidade (List<Musica> musicas, int key)
    {
        var musicasPorTonalidade = musicas.Where(musica => musica.Key == key).OrderBy(musica => musica.Nome)
            .Select(musica => musica.Nome).Distinct().ToList();
        Console.WriteLine($"Exibindo musicas na tonalidade {Musica.tonalidades[1]}");
        foreach (var musica in musicasPorTonalidade)
        {
            Console.WriteLine($"- {musica}");
        }
    }
}
