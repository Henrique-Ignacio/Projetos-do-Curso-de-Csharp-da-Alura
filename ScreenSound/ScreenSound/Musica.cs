
class Musica
{
    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }

    public string Nome {  get;}
    public Banda Artista {  get; }
    public int Duracao {  get; set; }
    public bool Disponivel {  get; set; }
    public string DescricaoResumida =>
        $"A música {Nome} pertence a banda {Artista}";
    public Genero genero { get; set; }
        


    public void ExibirFichaTecnica() 
    {

        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duração: {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine("Disponivel no plano");

        } else
        {
            Console.WriteLine("Adquira o plano Plus");
        }
    }

    // Faça como eu: 
    /* public void ExibirNomeEArtista()
    {
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Artista: {artista}");
    } */





}
