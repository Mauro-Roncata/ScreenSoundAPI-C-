﻿

using System.Text.Json.Serialization;

namespace ScreenSoundAPI.Modelos;

internal class Musica
{
    [JsonPropertyName("song")]
    public string Nome { get; set; }
    [JsonPropertyName("artist")]
    public string Artista { get; set; }
    [JsonPropertyName("duration_ms")]
    public int Duracao { get; set; }
    [JsonPropertyName("genre")]
    public string? Genero { get; set; }
    [JsonPropertyName("year")]
    public string? AnoString { get; set; }
    [JsonPropertyName("key")]
    public int Key { get; set; }
    public static string[] tonalidades = { "C", "C#", "D", "Eb", "E", "F", "F#", "G", "Ab", "A", "Bb", "B" };

    public string Tonalidade
    {
        get
        {
            return tonalidades[Key];
        }             
    }

    public int Ano
    {
        get
        {
            return int.Parse(AnoString!);
        }
    }

    public void ExibirDetalhesMusica()
    {
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Musica: {Nome}");
        Console.WriteLine($"Duração em segundos: {Duracao /1000}");
        Console.WriteLine($"Genero musical: {Genero}");
        Console.WriteLine($"Tonalidade: {Tonalidade}");
    }
}
