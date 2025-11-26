using static System.Runtime.InteropServices.JavaScript.JSType;

class Episodio 
{
    private List<string> convidados = new();

    public Episodio(string titulo, int numero, int duracao)
    {
        Titulo = titulo;
        Numero = numero;
        Duracao = duracao;
    }

    public string Titulo { get;}
    public int Numero { get; set; }
    public string Resumo => $"{Numero}. {Titulo} ({Duracao} min) - {string.Join(", ", convidados)} "; 
      
    public int Duracao { get;}

   public void AdicionarConvidados(string convidado)
    {
      convidados.Add(convidado);
    }

        
}
