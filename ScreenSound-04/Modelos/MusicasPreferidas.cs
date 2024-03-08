namespace ScreenSound_04.Modelos;
using System.Text.Json;
internal class MusicasPreferidas
{
    public List<Musica> ListaDeMusicasFavoristas { get; }
    public string? Nome { get; set; }

    public MusicasPreferidas(string nome)
    {
        Nome = nome;
        ListaDeMusicasFavoristas = new List<Musica>();
    }

    public void AdicionarMusicasFavoristas(Musica musica)
    {
        ListaDeMusicasFavoristas.Add(musica);
    }
    public void ExibirMusicasFavoritas()
    {

        Console.WriteLine($"Essas são as músicas favoritas {Nome}");

        foreach (var musica in ListaDeMusicasFavoristas)
        {
            Console.WriteLine($"- {musica.Nome} de {musica.Artista}");
        }
        Console.WriteLine();
    }

    public void GerarArquivoJson()
    {
        string json = JsonSerializer.Serialize(new
        {
            nome = Nome,
            musicas = ListaDeMusicasFavoristas
        });
        string nomeDoArquivo = $"musicas-favoritas-{Nome}.json";

        File.WriteAllText(nomeDoArquivo, json);
        Console.WriteLine($"O arquivo Json foi criado com sucesso!{Path.GetFullPath(nomeDoArquivo)}");

    }
}
