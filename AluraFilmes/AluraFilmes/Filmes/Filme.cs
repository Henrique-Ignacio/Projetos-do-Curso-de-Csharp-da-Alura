using System.Collections.Generic;

namespace AluraFilmes.Filmes;
class Filme
{
    public Filme(string titulo, int duração)
    {
        Titulo = titulo;
        Duração = duração;
       
    }

    public string Titulo { get; set; }
    public int Duração { get; set; }
    private List<Artista> elenco = new();
    public IReadOnlyList<Artista> Elenco => elenco.AsReadOnly();


}