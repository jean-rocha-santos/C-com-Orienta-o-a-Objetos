using  ScreenSound_04.Modelos;
using System.Text.Json;
using ScreenSound_04.Filtros;
using (HttpClient client = new HttpClient())
{
    try
        // tenta executar
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        // await espera a tarefa ser concluida para executala.
        
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        /*LinkFilter.FiltrarTodosOsGenerosMusicais(musicas);*/
        /*LinkOrder.ExibirListaDeArtistasOrdenados(musicas);*/
        /*LinkFilter.FiltrarArtistasPorGeneroMusical(musicas,"pop");*/
        /*LinkFilter.FiltrarMusicasPorArtista(musicas, "Justin Bieber");*/
        /*musicas[0].ExibirDetalhesMusica();*/
        LinkFilter.FiltrarPorTonalidade(musicas);
        

       /* var musicasPreferidasDoJean = new MusicasPreferidas("Jean");
        musicasPreferidasDoJean.AdicionarMusicasFavoristas(musicas[7]);
        musicasPreferidasDoJean.AdicionarMusicasFavoristas(musicas[77]);
        musicasPreferidasDoJean.AdicionarMusicasFavoristas(musicas[777]);
        musicasPreferidasDoJean.AdicionarMusicasFavoristas(musicas[1414]);
        musicasPreferidasDoJean.AdicionarMusicasFavoristas(musicas[1777]);
       */

        /*musicasPreferidasDoJean.GerarArquivoJson();*/

       /* var musicasPreferidasDaVitoria = new MusicasPreferidas("Vitória");
        musicasPreferidasDoJean.AdicionarMusicasFavoristas(musicas[4]);
        musicasPreferidasDoJean.AdicionarMusicasFavoristas(musicas[44]);
        musicasPreferidasDoJean.AdicionarMusicasFavoristas(musicas[444]);
        musicasPreferidasDoJean.AdicionarMusicasFavoristas(musicas[14]);
        musicasPreferidasDoJean.AdicionarMusicasFavoristas(musicas[41]);*/

        /*musicasPreferidasDoJean.ExibirMusicasFavoritas();*/




    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
} 