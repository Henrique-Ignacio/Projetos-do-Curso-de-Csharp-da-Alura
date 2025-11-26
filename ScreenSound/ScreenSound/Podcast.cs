class Podcast
{
    private List<Episodio> episodios = new();
    public Podcast(string host, string nome)
    {
        Host = host;
        Nome = nome;
    }

    public string Host {  get;}
    public int TotalEpisodios => episodios.Count;
    public string Nome { get;}

    public void AdicionarEpisodio(Episodio episodio)
    {
       episodios.Add(episodio);
    }
    public void ExibirDetalhes()
    {
        Console.Write($"Nome do podcast: {Nome} Host do podcast: {Host} \n");
        foreach(Episodio episodio in episodios.OrderBy(e => e.Numero))
        {
            Console.WriteLine(episodio.Resumo + "\n");
        }
        Console.WriteLine($"O total de episodios é: {TotalEpisodios}");
    }
}

