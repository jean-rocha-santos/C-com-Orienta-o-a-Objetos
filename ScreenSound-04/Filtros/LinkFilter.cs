using ScreenSound_04.Modelos;
namespace ScreenSound_04.Filtros;

internal class LinkFilter
{
    public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
    {
        var todosOsGeneroMusicais = musicas.Select(generos => generos.Genero
          ).Distinct().ToList();
        foreach (var genero in todosOsGeneroMusicais)
        {
            Console.WriteLine($"- " + genero);
        }
    }
    public static void FiltrarArtistasPorGeneroMusical(List<Musica> musicas, string genero)
    {
        var ArtistaPorGeneroMusical = musicas.Where(musica => musica.Genero!.Contains(genero)).
            Select(musica => musica.Artista).Distinct().ToList();
        Console.WriteLine($"Exibindo os artistas por gênero musical >>>> {genero}");
        foreach (var artista in ArtistaPorGeneroMusical)
        {
            Console.WriteLine($"- {artista}");
        }
    }
    public static void FiltrarMusicasPorArtista(List<Musica> musicas, string nome)
    {
        var MusicaPorArtista = musicas.Where(musica => musica.Artista!.Equals(nome)).
            Select(musica => musica.Nome).Distinct().ToList();
        Console.WriteLine($"Exibindo as musicas por artista >>>>> {nome}");
        foreach (var musica in MusicaPorArtista)
        {
            Console.WriteLine($"- {musica}");
        }
    }
    public static void FiltrarPorTonalidade(List<Musica> musicas)
    {
        var musicaPorTonalidade = musicas.Where(musica => musica.Tonalidade.Equals("C#")).
            Select(musica => musica.Nome).Distinct().ToList();

        foreach (var musica in musicaPorTonalidade)
        {
            Console.WriteLine($"- {musica} ");
        }
    }



}
