using ScreenSound_04.Modelos;
using ScreenSound_04.Filtros;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try 
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        
        LinqFilter.FiltrarMusicasPorTonalidade(musicas);

        // LinqFilter.FiltraTodosOsGeneros(musicas);
        // LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        // LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "rock");
        // LinqFilter.FiltrarMusicasDeUmArtista(musicas, "Michel Teló");
        //var musicasPreferidasDoDaniel = new MusicasPreferidas("Daniel");
        //musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[1]);
        //musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[377]);
        //musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[4]);
        //musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[6]);
        //musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[1467]);

        // musicasPreferidasDoDaniel.ExibirMusicasFavoritas();

        //var musicasPreferidasEmilly = new MusicasPreferidas("Emy");
        //musicasPreferidasEmilly.AdicionarMusicasFavoritas(musicas[500]);
        //musicasPreferidasEmilly.AdicionarMusicasFavoritas(musicas[637]);
        //musicasPreferidasEmilly.AdicionarMusicasFavoritas(musicas[428]);
        //musicasPreferidasEmilly.AdicionarMusicasFavoritas(musicas[13]);
        //musicasPreferidasEmilly.AdicionarMusicasFavoritas(musicas[71]);

        // musicasPreferidasEmilly.ExibirMusicasFavoritas();

        // musicasPreferidasEmilly.GerarArquivoJson();

    }
    catch (Exception ex)  
    {
        Console.WriteLine($"Temos um problema: {ex}");
    }
}
