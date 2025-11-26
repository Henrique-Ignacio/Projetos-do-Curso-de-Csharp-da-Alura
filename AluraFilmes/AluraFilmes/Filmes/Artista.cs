namespace AluraFilmes.Filmes;

class Artista
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public List<Filme> FilmesAtuados { get; set; } = new List<Filme>();

    public void CarregarFilmes(List<Filme> filmes)
    {
        FilmesAtuados = filmes
            .Where(f => f.Elenco == Nome)
            .ToList();
        
    }

}