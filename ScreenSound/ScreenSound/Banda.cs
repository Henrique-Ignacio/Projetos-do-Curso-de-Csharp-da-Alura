class Banda
{
    private List<Album> albums = new List<Album>();

    public Banda(string nome)
    {
        Nome = nome;
    }

    public string Nome {get;}
    public void AdicionarAlbum(Album album)
    {
        albums.Add(album);
    }
    public void ExibirDscografia()
    {
        Console.WriteLine($"Discografia da Banda: {Nome}");
        foreach (Album album in albums) {
            Console.WriteLine($"Álbum: {album.Nome} ({album.DuracaoTotal})");
        }

    }
}