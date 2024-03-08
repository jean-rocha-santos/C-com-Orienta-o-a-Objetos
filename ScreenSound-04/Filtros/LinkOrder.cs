using ScreenSound_04.Modelos;

namespace ScreenSound_04.Filtros;

internal class LinkOrder
{
    public static void ExibirListaDeArtistasOrdenados(List<Musica> musica)
    {
        var artistasOrdenados = musica.OrderBy(musica => musica.Artista).
            Select(musica => musica.Artista).Distinct().ToList();
        Console.WriteLine("Lista de artistas ordenados");
        foreach (var artist in artistasOrdenados)
        {
            Console.WriteLine($"- {artist}");
        }
    }
}
