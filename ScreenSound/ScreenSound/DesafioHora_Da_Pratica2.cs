class ContaBancaria2
{
    public int ID { get; set; }
    public string titular { get; set; }
    public double saldo { get; set; }
    public int senha { get; set; }

    void ExibirInformacoes()
    {
        Console.WriteLine($"O id da primeira conta é: {ID}");
        Console.WriteLine($"O titular da primeira conta é: {titular}");
        Console.WriteLine($"O saldo da primeira conta é: {saldo}");
        Console.WriteLine($"A senha da primeira conta é: {senha}");
    }


}

class carro2
{
    public int ID { get; set; }
    public string Nome { get; set; }
    public string Fabricante { get; set; }

    public int Velocidade { get; set; }
    public int Ano
    {
        get;
        set
        {
            if (value < 1960 || value > 2023)
            {
                Console.WriteLine("Insira um ano valido");
                return;
            }

        }
    }

    public string DescricaoDetalhada =>
       $"A carro {Nome} pertence a frabricante {Fabricante} e é do ano {Ano}";
   
   

    void acelerar()
    {
        Velocidade = Velocidade + 5;
    }
    void frear()
    {
        Velocidade = Velocidade - 5;
    }
    void buzinar()
    {
        Console.WriteLine("fon-fon");
    }
}

class Produto
{
    public string nome { get; set; }
    public string marca { get; set; }
    public double preco 
    { 
        get;
        set
        {
         if (value < 0)
            {
                Console.WriteLine("Insira um valor valido");
                return;
            }
        } 
    }
    public int estoque
    {
        get;
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Insira um valor valido");
                return;
            }
        }

    }
    public string Detalhamento => 
        $"O produto {nome} é da marca {marca}, custa R${preco} e tem {estoque} em estoque";

}