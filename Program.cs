using System.Text.Json;
using ScreenSoundAPI.Modelos;
using ScreenSoundAPI.Filtros;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;

        //LinqFiltro.FiltrarGeneros(musicas);
        //LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        //LinqFiltro.FiltrarArtistasPorGenero(musicas, "rock");
        //LinqFiltro.FiltrarMusicasDeUmArtista(musicas, "U2");
        //LinqFiltro.FiltrarMusicaPorAno(musicas, 2000);
        LinqFiltro.FiltrarMusicaPorTonalidade(musicas, 1);

        //var musicasPreferidasMauro = new MusicasPreferidas("Mauro");
        //musicasPreferidasMauro.AddMusicasFav(musicas[165]);
        //musicasPreferidasMauro.AddMusicasFav(musicas[203]);
        //musicasPreferidasMauro.AddMusicasFav(musicas[251]);
        //musicasPreferidasMauro.AddMusicasFav(musicas[1356]);
        //musicasPreferidasMauro.AddMusicasFav(musicas[1402]);

        //musicasPreferidasMauro.ExibirMusicasFav();

        //musicasPreferidasMauro.GerarArquivoJson();


        //musicas[10].ExibirDetalhesMusica();

    }
    catch (Exception ex)
    {
        Console.WriteLine($"Erro ao acessar a API: {ex.Message}");
    }

    
    
}