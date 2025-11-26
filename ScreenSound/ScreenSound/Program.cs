/* Album albumDoQueen = new Album("A night at the opera");

Genero rock = new Genero();
rock.Nome = "Rock";

Banda queen = new Banda("queen");

Musica musica1 = new Musica(queen, "Love of my life")
{
    Duracao = 213,
    Disponivel = true,
    genero = rock,
};

Musica musica2 = new Musica(queen, "Bohemian Rhapsody")
{
    Duracao = 354,
    Disponivel = false,
    genero = rock,
};
  

albumDoQueen.AdicionarMusica(musica1);
albumDoQueen.AdicionarMusica(musica2);

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
queen.AdicionarAlbum(albumDoQueen);
queen.ExibirDscografia();
*/

Episodio ep1 = new("Técnicas de facilitação",2 , 45);
ep1.AdicionarConvidados("Maria");
ep1.AdicionarConvidados("Marcelo");

Episodio ep2 = new("Técnicas de aprendizado", 1, 67);
ep2.AdicionarConvidados("Fernando");
ep2.AdicionarConvidados("Marcos");
ep2.AdicionarConvidados("Flavia");

Podcast podcast = new("Daniel", "podcast especial");
podcast.AdicionarEpisodio(ep1);
podcast.AdicionarEpisodio(ep2);
podcast.ExibirDetalhes();