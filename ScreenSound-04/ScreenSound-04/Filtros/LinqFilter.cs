using ScreenSound_04.Modelos;
namespace ScreenSound_04.Filtros;
internal class LinqFilter
{
    public static void FiltraTodosOsGeneros(List<Musica> musicas)
    {
        var todosOsGenerosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();
        foreach (var genero in todosOsGenerosMusicais)
        {
            Console.WriteLine($"- {genero} ");
        }
    }
    public static void FiltrarArtistasPorGeneroMusical(List<Musica> musicas, string genero)
    {

        var artistasPorGeneroMusical = musicas.Where(musica => musica.Genero!.Contains(genero))
            .Select(musica =>musica.Artista).Distinct().ToList() ;
        Console.WriteLine($"Exibindo os artistas por genero musical {genero}");
        foreach (var artista in artistasPorGeneroMusical)
        {
            Console.WriteLine($"- {artista}");
        }
    }
    public static void FiltrarMusicasDeUmArtista(List<Musica> musicas, string nomeDoArtista)
    {
        var musicasDoArtista = musicas.Where(musica => musica.Artista!.Equals(nomeDoArtista)).ToList();
        Console.WriteLine(nomeDoArtista);
        foreach (var musica in musicasDoArtista)
        {
            Console.WriteLine($"- {musica.Nome}");
        }
    }
    public static void ExibirKeyDaMusica(List<Musica> musicas)
    {
        //int keyDaMusica = musicas.Select(ky => ky.Key).FirstOrDefault();

        //switch (keyDaMusica) 
        //{
        //    case 0:  Console.WriteLine($"Tonalidade {keyDaMusica}: C"); break;
        //    case 1:  Console.WriteLine($"Tonalidade {keyDaMusica}: C#"); break;
        //    case 2:  Console.WriteLine($"Tonalidade {keyDaMusica}: D"); break;
        //    case 3:  Console.WriteLine($"Tonalidade {keyDaMusica}: D#"); break;
        //    case 4:  Console.WriteLine($"Tonalidade {keyDaMusica}: E"); break;
        //    case 5:  Console.WriteLine($"Tonalidade {keyDaMusica}: F"); break;
        //    case 6:  Console.WriteLine($"Tonalidade {keyDaMusica}: F#"); break;
        //    case 7:  Console.WriteLine($"Tonalidade {keyDaMusica}: G"); break;
        //    case 8:  Console.WriteLine($"Tonalidade {keyDaMusica}: G#"); break;
        //    case 9: Console.WriteLine($"Tonalidade {keyDaMusica}: A"); break;
        //    case 10: Console.WriteLine($"Tonalidade {keyDaMusica}: A#"); break;
        //    case 11: Console.WriteLine($"Tonalidade {keyDaMusica}: B"); break;
        //    default: Console.WriteLine("Tonalidade da musica invalida"); break;
        // }        
    }
    public static void FiltrarMusicasPorTonalidade(List<Musica> musicas)
    {
        
        var musicasDaTonalidade = musicas.Where(musica => musica.Tonalidade.Equals("C#"))
            .Select(musica => musica.Nome)
            .ToList();
        Console.WriteLine($"Musicas da tonalidade C#:");
        foreach (var musica in musicasDaTonalidade)
        {
            Console.WriteLine($"- {musica}");
        }
    }
}
