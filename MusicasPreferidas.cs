

using System.Text.Json;

namespace ScreenSoundAPI.Modelos;

internal class MusicasPreferidas
{
    public string? Nome { get; set; }
    public List<Musica> ListaDeMusicasFav { get; }

    public MusicasPreferidas(string nome)
    {
        Nome = nome;
        ListaDeMusicasFav = new List<Musica>();
    }

    public void AddMusicasFav(Musica musica)
    {
        ListaDeMusicasFav.Add(musica);
    }

    public void ExibirMusicasFav()
    {
        Console.WriteLine($"Lista de musicas preferidas de {Nome}:");
        foreach (var musica in ListaDeMusicasFav)
        {
            Console.WriteLine($"- {musica.Nome} - {musica.Artista} ({musica.Ano})");
        }
    }

    public void GerarArquivoJson()
    {
        string json = JsonSerializer.Serialize(new
        {
            nome = Nome,
            musicas = ListaDeMusicasFav
            
        });
        string caminhoArquivo = $"{Nome}_musicas_preferidas.json";

        File.WriteAllText(caminhoArquivo, json);
        Console.WriteLine($"Arquivo JSON gerado: {Path.GetFullPath(caminhoArquivo)}");

    }

}
